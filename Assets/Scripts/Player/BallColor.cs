using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallColor : MonoBehaviour
{
    public Dropdown ColorDropdown;
    //public Text ColorText;
    public GameObject PlayerBall;

    // Start is called before the first frame update
    void Start()
    {
        PlayerBall.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                //ColorText.text = ColorDropdown.options[1].text;
                PlayerBall.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                //ColorText.text = ColorDropdown.options[2].text;
                PlayerBall.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                //ColorText.text = ColorDropdown.options[3].text;
                PlayerBall.GetComponent<Renderer>().material.color = Color.green;
                break;
            default:
                //ColorText.text = ColorDropdown[0].text;
                PlayerBall.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}
