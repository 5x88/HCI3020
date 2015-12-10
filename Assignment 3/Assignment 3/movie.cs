using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;



namespace Assignment_3
{
    [Serializable]
    [XmlType(TypeName = "movie")]
    public class Movie {
        public String title, length, certification, director;
        int year, rating;
        public ArrayList genre, actors;


        //Null Constructor
        public Movie() { }

        //Constructor
        public Movie(String _title, String _length, String _certification, String _director,
            int _year, int _rating, ArrayList _genre, ArrayList _actors) {
            title = _title;
            length = _length;
            certification = _certification;
            director = _director;
            year = _year;
            rating = _rating;
            genre = _genre;
            actors = _actors;
        }
    }
}
