using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessManager : MonoBehaviour
{
    public GameObject[] cells;
    GameObject[,] board;

    // Start is called before the first frame update
    void Start()
    {
        board = new GameObject[8,8];
        int iCell = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = cells[iCell];
                iCell++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
