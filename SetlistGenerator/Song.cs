using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetlistGenerator
{
    class Song
    {
        private int id;
        private String name;
        private int length;
        public bool isSetlistBegin;
        public bool isSetlistEnd;
        private int balladVal;
        private int heavyVal;

        public Song(int id, String name, int length, bool isSetlistBegin, bool isSetlistEnd, int balladVal, int heavyVal)
        {
            this.id = id;
            this.name = name;
            this.length = length;
            this.isSetlistBegin = isSetlistBegin;
            this.isSetlistEnd = isSetlistEnd;
            this.balladVal = balladVal;
            this.heavyVal = heavyVal;
        }

        public int GetLength()
        {
            return this.length;
        }
    
        public int GetId()
        {
            return this.id;
        }

        public int GetHeavyVal()
        {
            return this.heavyVal;
        }

        public int GetBalladVal()
        {
            return this.balladVal;
        }
    }
}
