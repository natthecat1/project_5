using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxMoney(float money)
    {
        slider.maxValue = money;
        slider.value = money;
    }
    public void SetMoney(float money)
    {
        slider.value = money;
    }
}
