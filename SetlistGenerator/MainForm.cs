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
            //To-Do: Fill setlist in listview
            for (int i = 0; i < orderedSetlist.Count; i++)
            {
                setlistView.Columns.Add("" + i + 1, "" + orderedSetlist[i].GetName());
            }
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
    }
}
