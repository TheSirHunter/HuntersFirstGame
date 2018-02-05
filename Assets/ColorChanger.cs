using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color thisColor;
    // Use this for initialization
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = thisColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
