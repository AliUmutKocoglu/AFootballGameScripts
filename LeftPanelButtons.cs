using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LeftPanelButtons : MonoBehaviour
{
    public GameObject mainHomeMenu;
    public GameObject mainBackground;
    public GameObject pointTablePanel;
    public GameObject teamPanel;
    public GameObject nextMatchesPanel;
    public GameObject vss;
    public GameObject mainTeam;
    public GameObject scorePanel;
    public GameObject kayseri;
    public GameObject teamPanel1;
    public GameObject nextMatchesPanel1;
    public GameObject massagesPanel;
    public GameObject teamPanel2;
    public GameObject nextButton;
    public GameObject settingsButton;
    public GameObject nextPanel;
    public GameObject homeMenu;
    public GameObject pressConferencePanel;
    public GameObject pressRoomBackround;
    public GameObject tacticsPanel;
    public GameObject tacticsTable;
    public GameObject fourthreethree;
    public GameObject fourfourtwo;
    public GameObject fivefourone;
    public GameObject lockerRoom;
    public GameObject lockerRoomBack;
    public GameObject PressConferenceButton;
    public GameObject LockerRoomButton;
    public GameObject TacticsButton;
    public GameObject Deffensive;
    public GameObject Ballanced;
    public GameObject Agrassive;
    public GameObject matchResult;
    public GameObject matchResultBackground;
    public GameObject lockerRoomWin;
    public GameObject lockerRoomLose;
    public GameObject lockerRoomDraw;
    public GameObject lockerRoomButtonInResult;
    public GameObject pressConferencePanelWin;
    public GameObject pressConferencePanelLose;
    public GameObject pressConferencePanelDraw;
    public GameObject pressConferencePanelButtonInResult;
    public static int totalNum = 0;
    public static int adanaPoints = 0;

    public static LeftPanelButtons instance;
    public TextMeshProUGUI scoreText;
    public static string score = "0-0";

    public void ShowHomeMenu(int sceneId)
    {
        SceneManager.LoadScene(1);
    }
    public void ShowMessagesMenu() 
    { 
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        teamPanel2.SetActive(false);
        massagesPanel.SetActive(true);
    }
    public void showTeamMenu()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(true);
    }
    public void showNextMenu() 
    {
        mainBackground.SetActive(false);
        mainHomeMenu.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void showPressRoom()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        nextPanel.SetActive(false);
        pressConferencePanel.SetActive(true);
        pressRoomBackround.SetActive(true);
    }
    public void showTactic()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        nextPanel.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(true);
        tacticsPanel.SetActive(true);
    }
    public void fourthreethreeLineUp()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        nextPanel.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        fourfourtwo.SetActive(false);
        fivefourone.SetActive(false);
        tacticsTable.SetActive(true);
        tacticsPanel.SetActive(true);
        fourthreethree.SetActive(true);
    }
    public void fourfourtwoLineUp()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        nextPanel.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        fourthreethree.SetActive(false);
        fivefourone.SetActive(false);
        tacticsTable.SetActive(true);
        tacticsPanel.SetActive(true);
        fourfourtwo.SetActive(true);
    }
    public void fivefouroneLineUp()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        nextPanel.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        fourthreethree.SetActive(false);
        fourfourtwo.SetActive(false);
        tacticsTable.SetActive(true);
        tacticsPanel.SetActive(true);
        fivefourone.SetActive(true);
    }
    public void showLockerRoom()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        nextPanel.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(true);
        lockerRoomBack.SetActive(true);
    }
    public void clickCalm()
    {
        int RandomNum = UnityEngine.Random.Range(-2, 2);
        totalNum += RandomNum;
        Debug.Log(totalNum);
        Debug.Log(RandomNum);


        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        PressConferenceButton.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void clickNormal() 
    {
        int RandomNum = 0;
        totalNum += RandomNum;
        Debug.Log(totalNum);
        Debug.Log(RandomNum);

        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        PressConferenceButton.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void clickAgrassive()
    {
        int RandomNum = UnityEngine.Random.Range(-2, 4);
        totalNum += RandomNum;
        Debug.Log(totalNum);
        Debug.Log(RandomNum);

        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        PressConferenceButton.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void clickCalmInLockerRoom()
    {
        int LockerRandomNum = UnityEngine.Random.Range(-2, 3);
        totalNum += LockerRandomNum;
        Debug.Log(LockerRandomNum);
        Debug.Log(totalNum);


        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        LockerRoomButton.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void clickNormalInLockerRoom()
    {
        int LockerRandomNum = 0;
        totalNum += LockerRandomNum;
        Debug.Log(LockerRandomNum);
        Debug.Log(totalNum);

        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        LockerRoomButton.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void clickAgrassiveInLockerRoom()
    {
        int LockerRandomNum = UnityEngine.Random.Range(-3, 4);
        totalNum += LockerRandomNum;
        Debug.Log(LockerRandomNum);
        Debug.Log(totalNum);

        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        kayseri.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        LockerRoomButton.SetActive(false);
        nextPanel.SetActive(true);
    }
    public void deffensiveTactic()
    {
        Agrassive.SetActive(false);
        Ballanced.SetActive(false);
        Deffensive.SetActive(true); 
    }
    public void balancedTactic()
    {
        Agrassive.SetActive(false);
        Deffensive.SetActive(false);
        Ballanced.SetActive(true);
    }
    public void agrassiveTactic() 
    {
        Deffensive.SetActive(false);
        Ballanced.SetActive(false);
        Agrassive.SetActive(true);
    }
    public void saveTactics()
    {
        fourfourtwo.SetActive(false);
        fivefourone.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        fourthreethree.SetActive(false);
        nextPanel.SetActive(true);
        TacticsButton.SetActive(false);
    }

    public static int GetTotalNum()
    {
        return totalNum;
    }
    public static int GetAdanaNum()
    {
        return adanaPoints;
    }
    public void ShowMatchResult()
    {
        nextPanel.SetActive(false);
        matchResult.SetActive(true);
        matchResultBackground.SetActive(true);
        totalNum += UnityEngine.Random.Range(-3, 4);
        Debug.Log(totalNum);
    }
    public void showLockerRoominResult()
    {
        if (totalNum > 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            lockerRoomWin.SetActive(true);
        }
        if (totalNum < 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            lockerRoomLose.SetActive(true);
        }
        if (totalNum == 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            lockerRoomDraw.SetActive(true);
        }
        lockerRoomBack.SetActive(true);
    }

    public void clickNormalInLockerRoomInResult()
    {
        lockerRoomWin.SetActive(false);
        lockerRoomLose.SetActive(false);
        lockerRoomDraw.SetActive(false);
        lockerRoomButtonInResult.SetActive(false);
        lockerRoomBack.SetActive(false);
        matchResult.SetActive(true);
        matchResultBackground.SetActive(true);
    }

    public void clickNormalInPressRoomInResult()
    {
        pressConferencePanelWin.SetActive(false);
        pressConferencePanelLose.SetActive(false);
        pressConferencePanelDraw.SetActive(false);
        pressConferencePanelButtonInResult.SetActive(false);
        pressRoomBackround.SetActive(false);
        matchResult.SetActive(true);
        matchResultBackground.SetActive(true);
    }

    public void showPressRoomInResult()
    {
        if (totalNum > 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            pressConferencePanelWin.SetActive(true);
        }
        if (totalNum < 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            pressConferencePanelLose.SetActive(true);
        }
        if (totalNum == 0)
        {
            matchResult.SetActive(false);
            matchResultBackground.SetActive(false);
            pressConferencePanelDraw.SetActive(true);
        }
        pressRoomBackround.SetActive(true);
    }
    private void Awake()
    {
        instance = this;
    }
    public void result()
    {
        if (totalNum < 0 && totalNum >= -3)
        {
            score = "0-1";
        }
        else if (totalNum < -3 && totalNum >= -5)
        {
            score = "0-2";
        }
        else if (totalNum < -5 && totalNum >= -20)
        {
            score = "0-3";
        }
        else if (totalNum > 0 && totalNum <= 3)
        {
            score = "1-0";
        }
        else if (totalNum > 3 && totalNum <= 5)
        {
            score = "2-0";
        }
        else if (totalNum > 5 && totalNum <= 20)
        {
            score = "3-0";
        }
        else
        {
            score = "0-0";
        }
        scoreText.text = score.ToString();
    }
    public void nextMatchMainMenu()
    {
        int AdanaRandomNum = UnityEngine.Random.Range(-1, 2);
        adanaPoints += AdanaRandomNum;
        SceneManager.LoadScene(2);
    }
    public void showSecondNextMenu()
    {
        pointTablePanel.SetActive(false);
        teamPanel.SetActive(false);
        nextMatchesPanel.SetActive(false);
        vss.SetActive(false);
        mainTeam.SetActive(false);
        scorePanel.SetActive(false);
        teamPanel1.SetActive(false);
        nextMatchesPanel1.SetActive(false);
        massagesPanel.SetActive(false);
        teamPanel2.SetActive(false);
        nextButton.SetActive(false);
        settingsButton.SetActive(false);
        homeMenu.SetActive(false);
        pressConferencePanel.SetActive(false);
        pressRoomBackround.SetActive(false);
        tacticsTable.SetActive(false);
        tacticsPanel.SetActive(false);
        lockerRoom.SetActive(false);
        lockerRoomBack.SetActive(false);
        nextPanel.SetActive(true);
    }
}

