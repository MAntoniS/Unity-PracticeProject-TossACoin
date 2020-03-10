using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    public int cointToWin;
    public CoinCounter coinCounter;

    private void Start()
    {
        cointToWin = 10;
        coinCounter.SetCounter(cointToWin);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if collision is null
        if (collision.CompareTag("Coin")) 
        {
            AddACoin();
            //UpDate the CoinToWinCounter
            coinCounter.SetCounter(cointToWin);

        }
        
    }

    private void AddACoin()
    { 
        cointToWin--;
    }
}
