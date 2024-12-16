using UnityEngine;

public class LoginUI : MonoBehaviour
{
    public GameObject logInPrefab;
    public GameObject signUpPrefab;
    public GameObject mainViewPrefab;

    public GameObject canvas;

    public void ShowLogin()
    {
        HideAll();
        logInPrefab.SetActive(true);
    }

    public void ShowSignUp()
    {
        HideAll();
        signUpPrefab.SetActive(true);
    }

    public void ShowMain()
    {
        HideAll();
        mainViewPrefab.SetActive(true);
    }

    void HideAll()
    {
        GameObject[] activeViews = GameObject.FindGameObjectsWithTag("Page");
        foreach (GameObject view in activeViews)
        {
            view.SetActive(false);
        }
    }
}
