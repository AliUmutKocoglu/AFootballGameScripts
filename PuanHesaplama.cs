using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuanHesaplama : MonoBehaviour
{

    public TextMeshProUGUI adanaPointText;
    public static string adanaPointTable = "99";

    public static int GetAdanaNum()
    {
        return LeftPanelButtons.adanaPoints;
    }

    public void nextMatchMainMenu()
    {
        if (LeftPanelButtons.adanaPoints < 0)
        {
            adanaPointTable = "1";
        }
        else if(LeftPanelButtons.adanaPoints > 0) 
        { 
            adanaPointTable = "3";
        }
    }
}
