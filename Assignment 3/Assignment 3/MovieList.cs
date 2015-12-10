using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;



namespace Assignment_3
{

    public class Movie
    {
        [XmlElement("title")]
        public String title;
        [XmlElement("year")]
        public int year;
        [XmlElement("length")]
        public String length;
        [XmlElement("certification")]
        public String certification;
        [XmlElement("director")]
        public String director;
        [XmlElement("rating")]
        public int rating;
        [XmlElement("genre")]
        public String[] genre;
        [XmlElement("actor")]
        public String[] actor;



        //Null Constructor
        public Movie() { }

        //Constructor
        public Movie(String _title, String _length, String _certification, String _director,
            int _year, int _rating, String[] _genre, String[] _actor)
        {
            title = _title;
            length = _length;
            certification = _certification;
            director = _director;
            year = _year;
            rating = _rating;
            genre = _genre;
            actor = _actor;
        }
    }

    public class MovieList {
        [XmlArray("movielist"), XmlArrayItem(typeof(Movie), ElementName = "movie")]
        public List<Movie> movielist;
        public MovieList()
        {
            movielist = new List<Movie>();
        }
    }

}
