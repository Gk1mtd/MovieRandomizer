using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MovieRandomizer
{
    public class Mechanic : MonoBehaviour
    {
        int randomNumber;
        public GameObject textFeld;
        XMLReader myXMLReader;

        // Use this for initialization
        void Start()
        {
            //Debug.Log("Start");
            myXMLReader = new XMLReader();
        }
        // Update is called once per frame
        //void Update () {
        //       Debug.Log("Update");
        //   }

        public void ClickCode()
        {
            randomNumber = Random.Range(1,1000);
            //Debug.Log(randomNumber);
            textFeld.GetComponent<Text>().text = myXMLReader.GetMovies(randomNumber);
        }

    }
}