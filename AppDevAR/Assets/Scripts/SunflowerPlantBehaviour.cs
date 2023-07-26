using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunflowerBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public GameObject[] objects;
    public GameObject prefab;

    public GameObject marker;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeFlowerState();
        //OnClick();
    }

    public void ChangeFlowerState()
    {
        switch (slider.value)
        {
            case (4f):
                SetOthersInactive();
                objects[0].SetActive(true);
                return;
            case (5f):
                SetOthersInactive();
                objects[0].SetActive(true);
                return;
            case (7f):
                SetOthersInactive();
                objects[1].SetActive(true);
                return;
            case (8f):
                SetOthersInactive();
                objects[2].SetActive(true);
                return;
            case (9f):
                SetOthersInactive();
                objects[3].SetActive(true);
                return;
            case (10f):
                SetOthersInactive();
                objects[4].SetActive(true);
                return;
            default:
                SetOthersInactive();
                return;
        }
    }

    public void SetOthersInactive()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
    }

    /*
    public void OnClick()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject instan = Instantiate(prefab);
            instan.transform.position = marker.transform.position;
        }
    }*/
}
