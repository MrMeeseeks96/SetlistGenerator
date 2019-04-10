using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetlistGenerator
{
    /**
     * <summary>A class with all members, required for a song</summary>
     * */
    class Song
    {
        private int id;
        private String name;
        private int length;
        public bool isSetlistBegin;
        public bool isSetlistEnd;
        private int balladVal;
        private int heavyVal;

        /**
         * <summary>Constructor for the class</summary>
         * <param name="id">Unique id for the song</param>
         * <param name="name">Name of the song</param>
         * <param name="length">Duration of the song</param>
         * <param name="isSetlistBegin">Flag, is set when the song can be used at the beginnig of the setlist</param>
         * <param name="isSetlistEnd">Flag, is set when the song can be used to end the setlist</param>
         * <param name="balladVal">Value from 1-5 indicating how soft the song is</param>
         * <param name="heavyVal">Value from 1-5 indicationg how hard the song is</param>
         * */
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

        /**
         * <summary>Getter for the length member</summary>
         * <returns>returns the lenght of a song</returns>
         * */
        public int GetLength()
        {
            return this.length;
        }

        /**
         * <summary>Getter for the id member</summary>
         * <returns>returns the id of a song</returns>
         * */
        public int GetId()
        {
            return this.id;
        }

        /**
         * <summary>Getter for the name member</summary>
         * <returns>returns the name of a song</returns>
         * */
        public String GetName()
        {
            return this.name;
        }

        /**
         * <summary>Getter for the heavyVal member</summary>
         * <returns>returns the heavy value of a song</returns>
         * */
        public int GetHeavyVal()
        {
            return this.heavyVal;
        }

        /**
         * <summary>Getter for the balladVal member</summary>
         * <returns>returns the ballad value of a song</returns>
         * */
        public int GetBalladVal()
        {
            return this.balladVal;
        }
    }
}
