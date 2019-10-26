using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    Color prevColor;
    Color currColor;
    float changTime;
    // Start is called before the first frame update
    void Start()
    {
        prevColor = GetComponent<Renderer>().material.color;
        currColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        changTime = 0;
        GetComponent<Renderer>().material.color = prevColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            changTime = Time.time;
            prevColor = GetComponent<Renderer>().material.color;
            currColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            GetComponent<Renderer>().material.color = currColor;
        }
        GetComponent<Renderer>().material.color = Color.Lerp(prevColor, currColor, Mathf.Clamp(Time.time - changTime, 0.0f, 1.0f));
    }
}
