using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsView : MonoBehaviour
{
    public void LogOutBtn()
    {
        PlayerPrefs.SetFloat("LoggedIn", 0);
        SceneManager.LoadScene("Login");
    }
}
