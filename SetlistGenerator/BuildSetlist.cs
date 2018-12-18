using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace SetlistGenerator
{
    class BuildSetlist
    {
        private int fullSetlistLength;
        private int usedSetListLength;
        private List<Song> songs;
        static Random rand = new Random();

        public BuildSetlist(int fullSetlistLength)
        {
            this.fullSetlistLength = fullSetlistLength;
        }

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

        private void AddTime(int time)
        {
            this.usedSetListLength += time;
        }

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
                        if (songs[i].GetHeavyVal() > 3 && songs[i].GetBalladVal() < 2)
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
                        if (songs[i].GetHeavyVal() >= 3 && songs[i].GetBalladVal() <= 2)
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
            }
            while (!IsSongFinal() || 1 == songs.Count());
       
            setlist.Add(EndSetlist());
         

            return setlist;
        }

        public void InitializeSonglist()
        {
            XDocument songsXml = XDocument.Load("../../resources/songs.xml");

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

        public void SetFullSetlistLength(int fullSetlistLength)
        {
            this.fullSetlistLength = fullSetlistLength;
        }

        public int GetFullSetlistLength()
        {
            return this.fullSetlistLength;
        }
    }
}
