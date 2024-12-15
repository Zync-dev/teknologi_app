using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navbar : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject currentActiveButton;

    public Sprite[] homeSprites;
    public Sprite[] calendarSprites;
    public Sprite[] lessonsSprites;
    public Sprite[] friendsSprites;
    public Sprite[] menuSprites;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Home")
        {
            currentActiveButton = buttons[0];

            currentActiveButton.GetComponent<Image>().sprite = homeSprites[1];
        }
        if (SceneManager.GetActiveScene().name == "Lessons")
        {
            currentActiveButton = buttons[2];

            currentActiveButton.GetComponent<Image>().sprite = lessonsSprites[1];
        }
        if (SceneManager.GetActiveScene().name == "Calendar")
        {
            currentActiveButton = buttons[1];

            currentActiveButton.GetComponent<Image>().sprite = calendarSprites[1];
        }
        if (SceneManager.GetActiveScene().name == "Friends")
        {
            currentActiveButton = buttons[3];

            currentActiveButton.GetComponent<Image>().sprite = friendsSprites[1];
        }
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            currentActiveButton = buttons[4];

            currentActiveButton.GetComponent<Image>().sprite = menuSprites[1];
        }
    }

    public void HomeClick()
    {
        SceneManager.LoadScene("Home");
    }

    public void CalendarClick()
    {
        SceneManager.LoadScene("Calendar");
    }

    public void LessonsClick()
    {
        SceneManager.LoadScene("Lessons");
    }

    public void FriendsClick()
    {
        SceneManager.LoadScene("Friends");
    }

    public void MenuClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
