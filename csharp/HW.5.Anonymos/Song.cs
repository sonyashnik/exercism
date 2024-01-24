namespace HW._5.Anonymos
{
    public class Song
    {
        private string _name;
        private int _duration;
        private string _author;
        private int _year;

        public Song(string name, int duration, string author, int year)
        {
            _name = name;
            _duration = duration;
            _author = author;
            _year = year;
        }

        public object GetSong(Song song)
        {
            return (new {Title = song._name, Minutes = song._duration, AlbumYear = song._year});
        }
    }
}
