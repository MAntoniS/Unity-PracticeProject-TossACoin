using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject prefabCoin;

    public void TossACoin()
    {
            Instantiate(prefabCoin, transform.position, Quaternion.identity);
         
    }
}
