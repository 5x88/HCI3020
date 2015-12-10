using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void addFromWindow()
        {
            addNewXML(textBox1.text,textBox2.text,textBox3.text,textBox4.text,);
        }

        private void addNewXML(String title, int year, int length, String certification,
           String director, int rating, ArrayList genre, ArrayList actor)
        {
            XDocument doc = XDocument.Load("movies.xml");
            XElement movie = new XElement("movie",
                new XAttribute("title", title),
                new XElement("year", year),
                new XElement("length", length),
                new XElement("certification", certification),
                new XElement("director", director),
                new XElement("rating", rating));

                for (int i = 0; i < genre.Count; i++)
                {
                new XElement("genre", genre.);
                } 

                for (int i = 0; i < actor.Count; i++)
                {
                new XElement("genre", actor.elementAt(i));
                }

            doc.Root.Add(movie);
            doc.Save("test.xml");
        }


    }
}
