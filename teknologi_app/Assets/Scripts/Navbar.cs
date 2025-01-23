using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navbar : MonoBehaviour
{
    public GameObject[] buttons;
    int currentActivePage = 0; //0=Home, 1=Calendar, 2=Lessons, 3=Friends, 4=Menu, 5=Achievements, 6=Notifications, 7=Calendar_Chosen, 8=Lesson_Chosen

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

    public void LessonChosenClick()
    {
        currentActivePage = 8;
        ResetSprites();
        UpdatePage();
    }

    void UpdatePage()
    {
        HideAllPages();
        ShowPage(currentActivePage);
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


    public Slider lvlSlider;
    public TMP_Text[] lvlTxt;
    private void Update()
    {
        //Navbar-top level
        lvlSlider.value = (float)PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Exp");

        lvlTxt[0].text = Mathf.Floor((PlayerPrefs.GetInt($"{PlayerPrefs.GetInt("Name")}-Exp") / 100)).ToString();
        lvlTxt[1].text = ((Mathf.Floor((PlayerPrefs.GetInt($"{PlayerPrefs.GetInt("Name")}-Exp") / 100)))+1).ToString();
    }

    private void Start()
    {
        if (PlayerPrefs.GetFloat("LoggedIn") == 0)
        {
            SceneManager.LoadScene("Login");
        }
    }
}
