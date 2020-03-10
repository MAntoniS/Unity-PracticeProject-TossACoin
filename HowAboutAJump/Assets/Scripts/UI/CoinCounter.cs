using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{

    public Text counter;

    private void Start()
    {
        counter = GetComponentInChildren<Text>();
    }
    public void SetCounter(int coinCounter)
    {
        counter.text = coinCounter.ToString();
    }
}
