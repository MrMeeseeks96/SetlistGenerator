using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetlistGenerator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());

/*
            Button go = new Button { Left = 10, Top = 10, Text = "Start" };

            mainFrame.Controls.Add(go);

            mainFrame.ShowDialog();         */   
        }
    }
}
