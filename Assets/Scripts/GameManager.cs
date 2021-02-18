using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance;

    [SerializeField] GameObject gameBoard;
    public GameObject[,] blockBoard = new GameObject[10, 20];

    // Start is called before the first frame update
    void Start()
    {
        //Populating matrix of game objects
        for(int i =0; i < 10; i++)
        {
            for(int j = 0; j < 20; j++)
            {
                blockBoard[i, j] = GameObject.Find("Game Board/Row " + j + "/Block " + (i+1));
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        _instance = this;
    }

}
