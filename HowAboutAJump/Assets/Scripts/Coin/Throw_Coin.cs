using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Chest")) 
        {
            Destroy(this.gameObject);
        }
    }

}
