using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    public ControlCircle circle;
    // Use this for initialization
    void Start()
    {
        circle = FindObjectOfType<ControlCircle>();

    }

    // Update is called once per frame
    void Update()
    {
        if (circle == null)
        {
            transform.position = new Vector3(0, 0, -10);
            return;
        }
        transform.position = new Vector3(circle.transform.position.x, 0, -10);
    }
}
