using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBar : MonoBehaviour
{
    public Slider slider;

    public void SetBarCoin(int coins)
    {
        slider.value = coins;
    }


}
