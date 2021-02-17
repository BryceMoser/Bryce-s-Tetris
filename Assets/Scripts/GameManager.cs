using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[,] blockBoard = new GameObject[10, 20];
    [SerializeField] GameObject gameBoard;

    // Start is called before the first frame update
    void Start()
    {
        //Creating matrix of game objects
        for(int i =0; i < 10; i++)
        {
            for(int j = 0; j < 20; j++)
            {
                blockBoard[i, j] = GameObject.Find("Game Board/Row " + i + "/Block " + (j + 1));
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
