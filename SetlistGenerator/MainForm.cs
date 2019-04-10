using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetlistGenerator
{
    /**
     * <summary>Main GUI class, presents a input field for the .xml-file and listview component to see the ordered setlist</summary>
     * */
    public partial class MainForm : Form
    {
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
            int lenght = Int32.Parse(textBoxLength.Text);
            BuildSetlist setlist = new BuildSetlist(lenght);

            setlist.InitializeSonglist(filePath.Text);

            List<Song> orderedSetlist = setlist.FillSetlist();

            showList(orderedSetlist, setlistView);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * <summary>Will show a list numbered and with name of the songs in a listview</summary>
         * <param name="setlist">The ordered setlist to show</param>
         * <param name="v">The listview in which the data will be shown</param>
         * */
        private void showList(List<Song> setlist, ListView v)
        {
            v.View = View.Details;

            for (int i = 0; i < setlist.Count; i++)
            {
                v.Items.Add(new ListViewItem(new string[] { "" + (i + 1), "" + setlist[i].GetName() }));
            }
        }
    }
}
