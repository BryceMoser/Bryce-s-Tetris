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
            this.transform.Translate(-1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Translate(1, 0, 0);
        }
    }

    void DroppingDown()
    {
        this.transform.Translate(0, 0, -1);
    }
}
