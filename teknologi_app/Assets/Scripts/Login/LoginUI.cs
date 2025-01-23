using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginUI : MonoBehaviour
{
    [Header("Pages")]
    public GameObject logInPrefab;
    public GameObject signUpPrefab;
    public GameObject mainViewPrefab;

    [Header("Notifications")]
    public GameObject notifyPrefab;
    public GameObject canvas;

    void Start()
    {
        if(PlayerPrefs.GetFloat("LoggedIn") == 1)
        {
            SceneManager.LoadScene("App");
        }
    }

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

    public void SendNotification(string message, bool isError)
    {
        GameObject instantiatedNotify = Instantiate(notifyPrefab, canvas.transform);

        Notification notificationScript = instantiatedNotify.GetComponent<Notification>();

        notificationScript.message = message;
        notificationScript.isError = isError;
    }
}
