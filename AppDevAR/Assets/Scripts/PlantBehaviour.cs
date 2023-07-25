using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public GameObject[] objects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeFlowerState();
    }

    public void ChangeFlowerState()
    {
        if (slider.value == 5f)
        {
            SetOthersInactive();
            objects[1].SetActive(true);
        }
        else if (slider.value == 0f)
        {
            SetOthersInactive();
            objects[0].SetActive(true);
        }
    }

    public void SetOthersInactive()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
    }
}
