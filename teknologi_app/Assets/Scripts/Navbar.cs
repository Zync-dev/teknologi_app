using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navbar : MonoBehaviour
{
    public GameObject[] buttons;
    int currentActivePage = 0; //0=Home, 1=Calendar, 2=Lessons, 3=Friends, 4=Menu, 5=Achievements, 6=Notifications, 7=Calendar_Chosen

    public GameObject[] views;

    public Sprite[] homeSprites;
    public Sprite[] calendarSprites;
    public Sprite[] lessonsSprites;
    public Sprite[] friendsSprites;
    public Sprite[] menuSprites;

    // Navbar Top


    public void HomeClick()
    {
        currentActivePage = 0;
        ResetSprites();
        buttons[0].GetComponent<Image>().sprite = homeSprites[1];
        UpdatePage();
    }

    public void CalendarClick()
    {
        currentActivePage = 1;
        ResetSprites();
        buttons[1].GetComponent<Image>().sprite = calendarSprites[1];
        UpdatePage();
    }

    public void LessonsClick()
    {
        currentActivePage = 2;
        ResetSprites();
        buttons[2].GetComponent<Image>().sprite = lessonsSprites[1];
        UpdatePage();
    }

    public void FriendsClick()
    {
        currentActivePage = 3;
        ResetSprites();
        buttons[3].GetComponent<Image>().sprite = friendsSprites[1];
        UpdatePage();
    }

    public void MenuClick()
    {
        currentActivePage = 4;
        ResetSprites();
        buttons[4].GetComponent<Image>().sprite = menuSprites[1];
        UpdatePage();
    }

    public void AchievementsClick()
    {
        currentActivePage = 5;
        ResetSprites();
        UpdatePage();
    }

    public void NotificationsClick()
    {
        currentActivePage = 6;
        ResetSprites();
        UpdatePage();
    }

    public void CalendarChosenClick()
    {
        currentActivePage = 7;
        ResetSprites();
        UpdatePage();
    }

    void UpdatePage()
    {
        switch(currentActivePage)
        {
            case 0:
                HideAllPages();
                ShowPage(0);
                break;
            case 1:
                HideAllPages();
                ShowPage(1);
                break;
            case 2:
                HideAllPages();
                ShowPage(2);
                break;
            case 3:
                HideAllPages();
                ShowPage(3);
                break;
            case 4:
                HideAllPages();
                ShowPage(4);
                break;
            case 5:
                HideAllPages();
                ShowPage(5);
                break;
            case 6:
                HideAllPages();
                ShowPage(6);
                break;
            case 7:
                HideAllPages();
                ShowPage(7);
                break;
        }
    }

    void HideAllPages()
    {
        GameObject[] activeViews = GameObject.FindGameObjectsWithTag("Page");
        foreach (GameObject view in activeViews)
        {
            Destroy(view);
        }
    }

    void ResetSprites()
    {
        buttons[0].GetComponent<Image>().sprite = homeSprites[0];
        buttons[1].GetComponent<Image>().sprite = calendarSprites[0];
        buttons[2].GetComponent<Image>().sprite = lessonsSprites[0];
        buttons[3].GetComponent<Image>().sprite = friendsSprites[0];
        buttons[4].GetComponent<Image>().sprite = menuSprites[0];
    }

    void ShowPage(int page)
    {
        GameObject currentView = Instantiate(views[page], this.transform.parent.transform);
    }
}
