using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour
{
    [SerializeField] private Image EXPImage;
    [SerializeField] private float MaxEXPForLevelUP;
    private float currentEXP;

    public void EXPHandler(float xpAmount)
    {
        currentEXP += xpAmount;

        EXPImage.fillAmount = currentEXP / MaxEXPForLevelUP;
        if (currentEXP >= MaxEXPForLevelUP)
        {
            EXPImage.fillAmount = 0;
            //karakter level almıstır!! level++
        }
    }
}
