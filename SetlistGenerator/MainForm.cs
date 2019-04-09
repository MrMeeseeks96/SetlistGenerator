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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            BuildSetlist setlist = new BuildSetlist(1000000);

            setlist.InitializeSonglist(filePath.Text);

            List<Song> orderedSetlist = setlist.FillSetlist();

            showSetlist(orderedSetlist);
        }
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
