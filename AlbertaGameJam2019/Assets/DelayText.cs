using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayText : MonoBehaviour
{
    public GameObject buttons;
    public GameObject Credits;
    public GameObject title;
    float TmStart;
    float TmLen = 11.5f;

    // Use this for initialization
    void Start()
    {
        TmStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TmStart + TmLen)
        {
            Credits.SetActive(false);
            buttons.SetActive(true);
            title.SetActive(true);
        }
    }
}
