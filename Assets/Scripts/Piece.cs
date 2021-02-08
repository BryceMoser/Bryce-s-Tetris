using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DroppingDown", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Movement relative to the world
            this.transform.position += new Vector3(-1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Movement relative to the world
            this.transform.position += new Vector3(1, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            //Movement relative to the piece
            this.transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Movement relative to the piece
            this.transform.Rotate(0, -90, 0);
        }
    }

    void DroppingDown()
    {
        //Movement relative to the world
        this.transform.position += new Vector3(0, 0, -1);
    }
}
