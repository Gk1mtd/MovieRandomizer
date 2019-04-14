using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;
using System.Xml;
using System.IO;

namespace MovieRandomizer
{
    public class XMLReader : MonoBehaviour
    {
        XmlReader xmlReader;
        // Use this for initialization
        //void Start()
        //{
        //    //XmlReader xmlReader = XmlReader.Create("F:/Repository/Unity/MovieRandomizer/MovieRandomizer/Assets/Database/MovieDatabase1000.xml");
        //    //XmlReader xmlReader = XmlReader.Create(Application.dataPath + "/MovieDatabase1000.xml");
        //    //xmlReader = XmlReader.Create("http://meinerseitz.de/RandoMovie/MovieDatabase1000.xml");
        //  https://drive.google.com/file/d/1nw718wNMYcWvbJifW-6BIkoipKt4xnim/preview?usp=embed_googleplus
        //}
        // Update is called once per frame
        //void Update()
        //{
        //}

        public String GetMovies(int randomNumber, string xmlFile)
        {
            xmlReader = XmlReader.Create(new StringReader(xmlFile.ToString())); //füttert den xmlReader mit dem String aus der xmlFile aus der Zeile davor
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Movie"))
                {
                    if (xmlReader.HasAttributes)
                        if (xmlReader.GetAttribute("ID")==randomNumber.ToString())
                            return ("ID: " + xmlReader.GetAttribute("ID") + "\n" + "Title: " + xmlReader.GetAttribute("title") + "\n" + "Director: " + xmlReader.GetAttribute("director") + "\n" + "Year: " + xmlReader.GetAttribute("year") + "\n" + "Country: " + xmlReader.GetAttribute("country"));
                }
            }
            return("nichts gefunden zum lesen");
        }
    }
}