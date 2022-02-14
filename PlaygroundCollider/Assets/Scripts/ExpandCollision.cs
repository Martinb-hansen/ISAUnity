using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpandCollision : MonoBehaviour
{

    private Slider scaleSlider;

    public float scaleMinValue;
    public float scaleMaxValue;

    public GameObject Floor;
    public GameObject WallZ;
    public GameObject WallZMinus;
    public GameObject WallX;
    public GameObject WallXMinus;

    void Start()
    {


        scaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

    }

    void ScaleSliderUpdate(float value)
    {
        WallX.transform.localScale = new Vector3(1, 1, value+5);
        WallX.transform.position = new Vector3((value/2) + 3, 1, 0);

       // WallXMinus.transform.localScale = new Vector3(1, 1, value + 5);
       // WallXMinus.transform.position = new Vector3((-value / 2) - 3, 1, 0);

        Floor.transform.localScale = new Vector3(value+5, 1, value+5);
    }
}
