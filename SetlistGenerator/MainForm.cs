using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SetlistGenerator
{
    /**
     * <summary>Main GUI class, presents a input field for the .xml-file and listview component to see the ordered setlist</summary>
     * */
    public partial class MainForm : Form
    {
        /**
        * <summary>Initializes the main window</summary>
        * */
        public MainForm()
        {
            InitializeComponent();
        }

        /**
         * <summary>
         *  Auto-generated onCLick function. Will be executed when the "Start"-Button is pressed.
         *  Will call the <BuildSetlist cref="BuildSetlist"/> class and its associated functions to build a ordered setlist.
         * </summary>
         * */
        private void go_Click(object sender, EventArgs e)
        {
            if (textBoxLength.TextLength > 0)
            {
                int lenght = Int32.Parse(textBoxLength.Text) * 60;
                if (lenght > 0)
                {
                    BuildSetlist(lenght);
                }
                else
                {
                    textBoxLength.BackColor = Color.Red;
                }
            }
            else
            {
                textBoxLength.BackColor = Color.Red;
            }
        }

        /**
        * <summary>
        *  Auto-generated onCLick function. Will be executed when the "Browse..."-Button is pressed.
        *  Will call the a file dialog with which the correct .xml-File can be choosen.
        * </summary>
        * */
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog getFilePath = new OpenFileDialog();

            if (getFilePath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fp = getFilePath.FileName;
                filePath.Text = fp;

                BuildSetlist setlist = new BuildSetlist(1);
                setlist.InitializeSonglist(filePath.Text);
                List<Song> songlist = setlist.GetSonglist();
                showList(songlist, songlistView);
            }
        }

        /**
         * <summary>Will show a list numbered and with name of the songs in a listview</summary>
         * <param name="list">The ordered setlist to show</param>
         * <param name="v">The listview in which the data will be shown</param>
         * */
        private void showList(List<Song> list, ListView v)
        {
            v.Items.Clear();
            v.View = View.Details;

            for (int i = 0; i < list.Count; i++)
            {
                v.Items.Add(new ListViewItem(new string[] { "" + (i + 1), "" + list[i].GetName() }));
            }
        }

        /**
         * <summary>Will initialize a new songlist and will order it according to the given parameters</summary>
         * <param name="time">The duration of the setlist</param>
         * */
        private void BuildSetlist(int time)
        {
            BuildSetlist setlist = new BuildSetlist(time);

            if (filePath.TextLength > 0)
            {
                setlist.InitializeSonglist(filePath.Text);
                List<Song> orderedSetlist = setlist.FillSetlist();
                showList(orderedSetlist, setlistView);
            }
            else
            {
                filePath.BackColor = Color.Red;
            }
        }

        /**
         * <summary>Opens a new Window for designing a new songlist</summary>
         * */
        private void songlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddSonglistView().Show();
        }
    }
}
