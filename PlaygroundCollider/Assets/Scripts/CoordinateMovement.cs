using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System.IO;

public class CoordinateMovement : MonoBehaviour
{

    public Transform Target;

    public float speed;

    public float mutlpikatier;

    int stringL;
    string data;
    string[] data_values;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        ReadCSVFile(out data);

        data_values = data.Split(',');
        stringL = data_values.Length;

    }

    void FixedUpdate()
    {
     
        Vector3 a = transform.position;

        Target.transform.position = new Vector3(float.Parse(data_values[count].ToString(), CultureInfo.InvariantCulture)* mutlpikatier,
                                               float.Parse(data_values[count+1].ToString(), CultureInfo.InvariantCulture)* mutlpikatier,
                                               float.Parse(data_values[count+2].ToString(), CultureInfo.InvariantCulture)* mutlpikatier);

        Vector3 b = Target.position;

        transform.position = Vector3.MoveTowards(a, b, speed);

        count = count + 3;

        if (count >= stringL)
            count = 0;

    }

    // Update is called once per frame
    void ReadCSVFile(out string return1)
    {

        StreamReader strReader = new StreamReader("data.csv");

            string data_string = strReader.ReadLine();

        return1 = data_string;
        
    }

}




