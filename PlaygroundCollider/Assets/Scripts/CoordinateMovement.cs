using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System.IO;

public class CoordinateMovement : MonoBehaviour
{

    public GameObject Cube;

    int stringL;
    string data;


    // Start is called before the first frame update
    void Start()
    {
        ReadCSVFile(data);

        //var data_values = data_string.Split(',');
        //int stringLength = data_values.Length;



        //NÆSTE STEP!

        //Skal have lavet en update funktion, der bruger Vector3 MoveTowards, som tager 2 punkter og definere hvor lang tid det tager at bevæge objektet
        //SKal for hver update tage et nyt data punkt
        //Når stringL er nået, så afsluttes eller stoppes det
    }


    // Update is called once per frame
    void ReadCSVFile(out string return1)
    {

       // int i = 0;
        StreamReader strReader = new StreamReader("data.csv");
        //bool endOfFile = false;

        

        //while (!endOfFile)
        //{
            string data_string = strReader.ReadLine();

        //if (data_string == null)
        //{
        //    endOfFile = true;
        //    break;
        //}

        // if (i >= (sizeof.(data_string)) - 3)
        //   break;



        //x = float.Parse(data_values[0].ToString());






        //for (int i = 0; i >= stringLength; i++) {

        //int i = 0;

        //while(i >= stringLength) { 

        //Debug.Log(data_values[0].ToString());

        //Cube.transform.position = new Vector3(float.Parse(data_values[0].ToString(), CultureInfo.InvariantCulture),
        //                                         float.Parse(data_values[1].ToString(), CultureInfo.InvariantCulture),
        //                                       float.Parse(data_values[2].ToString(), CultureInfo.InvariantCulture));

        //WaitFive();

        //Debug.Log(data_values[3].ToString());
        //Cube.transform.position = new Vector3(3,2,4);

        //Debug.Log(float.Parse("-0.9848484848", CultureInfo.InvariantCulture));

        //Debug.Log(data_values[0].ToString());
        //Debug.Log(data_values[1].ToString());
        //Debug.Log(data_values[2].ToString());

        //i = i + 3;


        // }

        //}


        return1 = data_string;
        
    }

    IEnumerator WaitFive()
    {

        yield return new WaitForSeconds(5);
    }
}

void Update()
    {
    //Debug.Log(data_values[0].ToString());

    //Cube.transform.position = new Vector3(float.Parse(data_values[0].ToString(), CultureInfo.InvariantCulture),
    //                                         float.Parse(data_values[1].ToString(), CultureInfo.InvariantCulture),
    //                                       float.Parse(data_values[2].ToString(), CultureInfo.InvariantCulture));

    //WaitFive();



    //Debug.Log(data_values[3].ToString());
    //Cube.transform.position = new Vector3(3, 2, 4);
}



