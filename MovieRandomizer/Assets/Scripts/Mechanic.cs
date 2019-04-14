using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;
namespace MovieRandomizer
{
    public class Mechanic : MonoBehaviour
    {
        int randomNumber;                       //hält die zufällig generierte Nummer zur Auswahl einer FilmID
        public GameObject textFeld;             //hält das GameObject des Textfeldes das den ausgesuchten Film anzeigen soll
        public GameObject thisButton;
        XMLReader myXMLReaderClass;             //unsere eigene XMLReader Klasse wird deklariert
        string xmlFile;                         //Deklariert den String der dann die komplette MovieDatabase-XML-File als String bereit hält
        

        // Use this for initialization
        void Start()
        {
            myXMLReaderClass = new XMLReader();
            xmlFile = Resources.Load<TextAsset>("MovieDatabase1000").ToString();       //läd die XML File direkt aus dem serialisierten Resourcen Ordner in eine zwischen var
            var audioClip = Resources.Load<AudioClip>("CranialMenu");
            this.GetComponent<AudioSource>().clip = audioClip;
            this.GetComponent<AudioSource>().Play();
        }
        // Update is called once per frame
        //void Update () {
        //       Debug.Log("Update");
        //   }

        public void ClickCode()
        {
            thisButton.GetComponent<Animation>().Play();
            randomNumber = Random.Range(1,1000);
            textFeld.GetComponent<Text>().text = myXMLReaderClass.GetMovies(randomNumber, xmlFile);
        }

    }
}