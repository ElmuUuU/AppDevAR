using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public TMP_Text UItext;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ChangeMonth();
    }

    public void ChangeMonth()
    {
        switch (slider.value)
        {
            case (0f):
                UItext.text = "January";
                return;
            case (1f):
                UItext.text = "February";
                return;
            case (2f):
                UItext.text = "March";
                return;
            case (3f):
                UItext.text = "April";
                return;
            case (4f):
                UItext.text = "May";
                return;
            case (5f):
                UItext.text = "June";
                return;
            case (6f):
                UItext.text = "July";
                return;
            case (7f):
                UItext.text = "August";
                return;
            case (8f):
                UItext.text = "September";
                return;
            case (9f):
                UItext.text = "October";
                return;
            case (10f):
                UItext.text = "November";
                return;
            case (11f):
                UItext.text = "December";
                return;
            default:
                return;
        }
    }
}
