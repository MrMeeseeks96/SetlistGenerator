using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace SetlistGenerator
{
    /**
     * <summary>class to build a ordered setlist, accounting the member values in class <Song cref="Song"/></summary>
     * */
    class BuildSetlist
    {
        private int fullSetlistLength;
        private int usedSetListLength;
        private List<Song> songs;
        static Random rand = new Random();

        /**
         * <summary>Constructor, initializes the class and sets the maxmimum lenght of the set</summary>
         * <param name="fullSetlistLength">The maximum lenght of the setlist</param>
         * */
        public BuildSetlist(int fullSetlistLength)
        {
            SetFullSetlistLength(fullSetlistLength);
        }

        /**
         * <summary>Deletes a song from the list</summary>
         * <param name="id">the id required to find the correct song to delete</param>
         * */
        private void DeleteSong(int id)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].GetId() == id)
                {
                    songs.RemoveAt(i);
                }
            }
        }

        /**
         * <summary>Adds the length of the used song to the overall used time</summary>
         * <param name="time">the duration that needs to be added</param>
         * */
        private void AddTime(int time)
        {
            this.usedSetListLength += time;
        }

        /**
         * <summary>Starts the setlist by randomly finding a song that qualifies as a beginning song</summary>
         * <returns>Returns the song that was choosen</returns>
         * */
        private Song BeginSetlist()
        {
            List<Song> beginningSongs = new List<Song>();

            for (int i = 0; i < (songs.Count); i++)
            {
                if (songs[i].isSetlistBegin)
                {
                    beginningSongs.Add(songs[i]);
                }
            }

            int r = rand.Next(beginningSongs.Count);
            Song firstSong = beginningSongs[r];

            AddTime(firstSong.GetLength());
            DeleteSong(firstSong.GetId());

            return firstSong;
        }

        /**
         * <summary>Checks if the there is time for more than one song or if the next one is the last one</summary>
         * <returns>Returns true if the next song must be the last one. Returns false if there is time for more than one song</returns>
         * */
        private bool IsSongFinal()
        {
            int leftoverTime = fullSetlistLength - usedSetListLength;
            Song longestSong = songs.Aggregate((curMax, x) => curMax == null || x.GetLength() > curMax.GetLength() ? x : curMax);

            int maxLength = longestSong.GetLength();

            if (leftoverTime < 0)
            {
                return true;
            }
            else if (leftoverTime >= maxLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /**
         * <summary>Chooses the last song randomly from all possible final songs</summary>
         * <returns>Returns the song that was choosen as final song</returns>
         * */
        private Song EndSetlist()
        {
            List<Song> endingSongs = new List<Song>();

            for (int i = 0; i < (songs.Count); i++)
            {
                if (songs[i].isSetlistEnd)
                {
                    endingSongs.Add(songs[i]);
                }
            }

            int r = rand.Next(endingSongs.Count);
            Song finalSong = endingSongs[r];

            AddTime(finalSong.GetLength());
            DeleteSong(finalSong.GetId());

            return finalSong;
        }

        /**
         * <summary>
         *  Chooses the songs 2 - n-1.
         *  Second song must be heavy, so only those will qualify. Third song will be choosen completly random.
         *  All other songs will be choosen after a simple algorithm. If the last song was a ballad choose a heavy song else choose any song.
         * </summary>
         * <returns>Returns a complete, ordered list that can be used as a setlsit</returns>
         * */
        public List<Song> FillSetlist()
        {
            List<Song> setlist = new List<Song>();

            setlist.Add(BeginSetlist());

            Song lastSong = null;
            int r;
            Song currentSong;

            do
            {
                List<Song> currentOptions = new List<Song>();

                //Choose second song
                if (1 == setlist.Count && !IsSongFinal())
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (songs[i].GetBalladVal() < 2)
                        {
                            currentOptions.Add(songs[i]);
                        }
                    }
                    r = rand.Next(currentOptions.Count);
                    currentSong = currentOptions[r];

                    if (!currentSong.isSetlistEnd)
                    {
                        setlist.Add(currentSong);
                        lastSong = currentSong;

                        AddTime(currentSong.GetLength());
                        DeleteSong(currentSong.GetId());
                    }
                }

                //choose third song
                if (2 == setlist.Count && !IsSongFinal())
                {
                    r = rand.Next(songs.Count);
                    currentSong = songs[r];

                    if (!currentSong.isSetlistEnd)
                    {
                        setlist.Add(currentSong);
                        lastSong = currentSong;

                        AddTime(currentSong.GetLength());
                        DeleteSong(currentSong.GetId());
                    }
                }

                //choose song four to x
                if (lastSong.GetBalladVal() >= 3 && !IsSongFinal())
                {
                    for (int i = 0; i < songs.Count; i++)
                    {
                        if (songs[i].GetHeavyVal() >= 3)
                        {
                            currentOptions.Add(songs[i]);
                        }
                    }

                    if (0 == currentOptions.Count)
                    {
                        break;
                    }

                    r = rand.Next(currentOptions.Count);
                    currentSong = currentOptions[r];

                    if (!currentSong.isSetlistEnd)
                    {
                        setlist.Add(currentSong);
                        lastSong = currentSong;

                        AddTime(currentSong.GetLength());
                        DeleteSong(currentSong.GetId());
                    }
                }
                else if (lastSong.GetBalladVal() <= 2 && !IsSongFinal())
                {
                    r = rand.Next(songs.Count);
                    currentSong = songs[r];

                    if (!currentSong.isSetlistEnd)
                    {
                        setlist.Add(currentSong);
                        lastSong = currentSong;

                        AddTime(currentSong.GetLength());
                        DeleteSong(currentSong.GetId());
                    }
                }

                int lefotovercount = 0;
                for (int i = 0; i < songs.Count(); i++)
                {
                    if (!songs[i].isSetlistEnd)
                    {
                        lefotovercount++;
                    }
                }

                if (lefotovercount == 0)
                {
                    break;
                }
            }
            while (!IsSongFinal() && songs.Count() > 1);
       
            setlist.Add(EndSetlist());
         

            return setlist;
        }

        /**
         * <summary>Initializes a list with all possible songs from an .xml-file</summary>
         * <param name="path">The path to the .xml-file</param>
         * */
        public void InitializeSonglist(String path)
        {
            XDocument songsXml = XDocument.Load(path);

            songs =
                songsXml.Root.Elements("song")
                .Select(s => new Song(
                    int.Parse(s.Element("id").Value),
                    (string)s.Element("name"),
                    int.Parse(s.Element("length").Value),
                    bool.Parse(s.Element("isBegin").Value),
                    bool.Parse(s.Element("isEnd").Value),
                    int.Parse(s.Element("balladVal").Value),
                    int.Parse(s.Element("heavyVal").Value)
                ))
                .ToList();
        }

        /**
         * <summary>Setter for the maximum setlist length</summary>
         * <param name="fullSetlistLength">The maximum setlsit length</param>
         * */
        public void SetFullSetlistLength(int fullSetlistLength)
        {
            if(fullSetlistLength > 0)
            {
                this.fullSetlistLength = fullSetlistLength;
            }
        }

        /**
         * <summary>Getter for the full setlist length</summary>
         * <returns>Returns the full setlist length</returns>
         * */
        public int GetFullSetlistLength()
        {
            return this.fullSetlistLength;
        }

        /**
         * <summary>Getter for the full songlist</summary>
         * <returns>Returns the full songlist</returns>
         * */
        public List<Song> GetSonglist()
        {
            return this.songs;
        }
    }
}
