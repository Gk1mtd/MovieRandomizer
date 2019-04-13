using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;
using System.Xml;
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
        //}
        // Update is called once per frame
        //void Update()
        //{
        //}

        public String GetMovies(int randomNumber)
        {
            xmlReader = XmlReader.Create("http://meinerseitz.de/RandoMovie/MovieDatabase1000.xml");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Movie"))
                {
                    if (xmlReader.HasAttributes)
                        if (xmlReader.GetAttribute("ID")==randomNumber.ToString())
                            return ("Title: " + xmlReader.GetAttribute("title") + "\n" + "Director: " + xmlReader.GetAttribute("director") + "\n" + "Year: " + xmlReader.GetAttribute("year") + "\n" + "Country: " + xmlReader.GetAttribute("country"));
                }
            }
            return ("");
        }
        //{
        //    XmlReader xmlReader = XmlReader.Create("F:/Repository/Unity/MovieRandomizer/MovieRandomizer/Assets/Database/MovieDatabase.xml");
        //    Debug.Log(xmlReader.ReadString());
        //}
    }
}