using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CoordinateMovement : MonoBehaviour
{

    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        ReadCSVFile();
    }

    // Update is called once per frame
    void ReadCSVFile()
    {
        StreamReader strReader = new StreamReader("data.csv");
        bool endOfFile = false;
        while(!endOfFile)
        {
            string data_string = strReader.ReadLine();

            if (data_string == null)
            {
                endOfFile = true;
                break;
            }

            var data_values = data_string.Split(',');

            //x = float.Parse(data_values[0].ToString());

            Cube.transform.position = new Vector3(float.Parse(data_values[0].ToString()),
                                                float.Parse(data_values[1]),
                                                float.Parse(data_values[2]));

            Debug.Log(data_values[0].ToString());
            Debug.Log(data_values[1].ToString());
            Debug.Log(data_values[2].ToString());


        }
    }
}
