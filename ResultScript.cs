using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScript : MonoBehaviour
{
    public GameObject lockerRoomButton;
    public GameObject skipButton;
    public GameObject matchResult;
    public GameObject matchResultBackground;
    public GameObject pressConferencePanel;
    public GameObject pressRoomBackround;
    public GameObject lockerRoomWin;
    public GameObject lockerRoomLose;
    public GameObject lockerRoomDraw;
    public GameObject lockerRoomBack;

    static int resultValue= LeftPanelButtons.GetTotalNum();


    public void showLockerRoom()
    {
        if(resultValue> 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            lockerRoomWin.SetActive(true);
        }
        if (resultValue< 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            lockerRoomLose.SetActive(true);
        }
        if(resultValue==0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            lockerRoomDraw.SetActive(true);
        }
        lockerRoomBack.SetActive(true);
    }
    public void clickNormalInLockerRoom()
    {
        lockerRoomWin.SetActive(false);
        lockerRoomLose.SetActive(false);
        lockerRoomDraw.SetActive(false);
        lockerRoomButton.SetActive(false);
        matchResult.SetActive(true);
        matchResultBackground.SetActive(true);
    }
}
