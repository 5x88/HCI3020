using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.Text;
using System.Xml;

namespace Assignment_3
{
    static class Program
    {
        public static MovieList movies;
        public static MovieList watchList;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            movies = readFile();
            Application.Run(new MainScreen());
        }


        //Pass in a movie list object and it will write to the xml file.
        public static void writeFile()
        {


            var xml = new StringBuilder();

            using (var writer = XmlWriter.Create(xml, new XmlWriterSettings { OmitXmlDeclaration = true } ) );

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");



            var xs = new XmlSerializer(typeof(MovieList));
            var wfile = new System.IO.StreamWriter(@"movies.xml");
            xs.Serialize(wfile, movies, ns);
            wfile.Close();
        }

        //Call this function to get the list from the XML file. Take note the XML file needs an extra
        // <MovieList> encapsulating the whole thing in 
        public static MovieList readFile()
        { 
            XmlSerializer reader = new XmlSerializer(typeof(MovieList));
            System.IO.StreamReader file = new System.IO.StreamReader(@"movies.xml");
            MovieList moviesDeserialzed = (MovieList)reader.Deserialize(file);
            file.Close();
            return moviesDeserialzed;
        }

    }


}
