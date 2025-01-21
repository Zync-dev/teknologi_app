using UnityEngine;

public class LessonsPage : MonoBehaviour
{
    Navbar navbarScript;

    int chosenLesson;

    private void Start()
    {
        navbarScript = GameObject.FindGameObjectWithTag("NavBar").GetComponent<Navbar>();

        if(PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-TeoriWelcomeAccept") == 1)
        {
            welcomePopUpObj.SetActive(false);
        }
    }

    public void LessonBtnClick(int id)
    {
        chosenLesson = id;
        ShowPage();
    }

    void ShowPage()
    {
        navbarScript.LessonChosenClick();

        GameObject LessonsChosenPageObj = GameObject.Find("LessonQuizIntro_Page(Clone)");
        LessonsQuiz lessonsChosenPageScript = LessonsChosenPageObj.GetComponent<LessonsQuiz>();

        lessonsChosenPageScript.InstantiateQuiz(chosenLesson);
    }

    // Welcome pop-up
    public GameObject welcomePopUpObj;

    public void OnWelcomeAccept()
    {
        PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-TeoriWelcomeAccept", 1);
        Destroy(welcomePopUpObj);
    }
}
