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
            BuildSetlist setlist = new BuildSetlist(1000000);

            setlist.InitializeSonglist(filePath.Text);

            List<Song> orderedSetlist = setlist.FillSetlist();

            showSetlist(orderedSetlist);
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
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * <summary>Will show the ordered setlist numbered and with name of the songs in a listview</summary>
         * <param name="setlist">The ordered setlist to show</param>
         * */
        private void showSetlist(List<Song> setlist)
        {
            setlistView.View = View.Details;

            for (int i = 0; i < setlist.Count; i++)
            {
                setlistView.Items.Add(new ListViewItem(new string[] { "" + (i + 1), "" + setlist[i].GetName() }));
            }
        }
    }
}
