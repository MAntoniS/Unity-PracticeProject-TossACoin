using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGathering : MonoBehaviour
{

    public CoinBar coinBar;
    public int coins;
    public Throw t;
  
    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        t = GetComponentInChildren<Throw>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && coins > 0)
        {
            //Toss a Coin
            t.TossACoin();
            //Lose a coin from the Player chest
            LoseACoin();
        }
        
    }
    public void GetACoin()
    {
        coins++;
        coinBar.SetBarCoin(coins);
    }

    

    public void LoseACoin() 
    {
        coins--;
        coinBar.SetBarCoin(coins);
    }
}
