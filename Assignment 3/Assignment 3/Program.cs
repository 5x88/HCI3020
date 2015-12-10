using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Movie movies = readFile();
            //Movie test = (Movie)movies[0];
          //  MessageBox.Show(movies.title);


            Application.Run(new MainScreen());
        }

        public static Movie readFile()
        {
            ArrayList movies = new ArrayList();
            ArrayList genre = new ArrayList();
            ArrayList actors = new ArrayList();
            genre.Add("Drama");
            genre.Add("Comedy");
            actors.Add("Samuel L Jackson");
            actors.Add("Bruce Willis");
            actors.Add("John Travolta");

            Movie temp = new Movie("Pulp Fiction", "Two Hours", "R", "QT", 1994, 10, genre, actors);
            //movies.Add(temp);
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(Movie));
            var wfile = new System.IO.StreamWriter(@"test.xml");
            writer.Serialize(wfile, temp);
            wfile.Close();


            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Movie));
            System.IO.StreamReader file = new System.IO.StreamReader(@"test.xml");
            Movie moviesDeserialzed = (Movie)reader.Deserialize(file);
            file.Close();
            return temp;
            //return moviesDeserialzed;
        }

    }

}
