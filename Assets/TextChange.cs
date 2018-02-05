using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChange : MonoBehaviour
{
    private TextMesh mesh;
    public float TextKeyCount;
    public float SpaceBarCount;
    // Use this for initialization
    void Start()
    {
        mesh = GetComponent<TextMesh>();
        TextKeyCount = 1;
        SpaceBarCount = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceBarCount++;
        }

        if (Input.GetKeyDown(KeyCode.Space) && TextKeyCount == 1)
        {
            TextKeyCount = 2;
            mesh.text = "Press A and D to move left and right.";
        }
        if( (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && TextKeyCount == 2)
        {
            TextKeyCount = 3;
            mesh.text = "Press Space twice to double jump";
            SpaceBarCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && TextKeyCount == 3 && SpaceBarCount >= 2)
        {
            TextKeyCount = 4;
            mesh.text = "Tutorial Complete.";
        }
    }
}

