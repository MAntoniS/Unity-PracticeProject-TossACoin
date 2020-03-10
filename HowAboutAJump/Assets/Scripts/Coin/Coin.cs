using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        //CHECK IF OTHER == TAG.PLAYER
        //CHECK IF NOT NULL
        CoinGathering coinGather = other.GetComponent<CoinGathering>();
        coinGather.GetACoin();
        Destroy(this.gameObject);
    }
}
