using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetlistGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildSetlist setlist = new BuildSetlist(1000000);

            setlist.InitializeSonglist();

            setlist.FillSetlist();
        }
    }
}
