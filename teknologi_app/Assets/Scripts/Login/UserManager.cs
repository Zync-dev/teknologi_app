using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using TMPro;
using UnityEngine.SceneManagement;

public class UserManager : MonoBehaviour
{
    private const string USER_DATA_FILE = "user_data.json";

    private List<User> users = new List<User>();

    public TMP_InputField usernameInputField;
    public TMP_InputField passwordInputField;
    public TMP_InputField emailInputField;

    GameObject gameManager;
    LoginUI loginScript;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        loginScript = gameManager.GetComponent<LoginUI>();
        LoadUsers();
    }

    public void CreateUser(string username, string password, string email)
    {
        User user = new User(username, password, email);
        users.Add(user);
        SaveUsers();
    }

    public bool Login(string username, string password)
    {
        foreach (User user in users)
        {
            if (user.username == username && user.password == password)
            {
                return true;
            }
        }
        return false;
    }

    private void LoadUsers()
    {
        string filePath = Path.Combine(Application.persistentDataPath, USER_DATA_FILE);
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            users = JsonConvert.DeserializeObject<List<User>>(jsonData);
        }
    }

    private void SaveUsers()
    {
        string filePath = Path.Combine(Application.persistentDataPath, USER_DATA_FILE);
        string jsonData = JsonConvert.SerializeObject(users);
        File.WriteAllText(filePath, jsonData);
    }

    public void OnLoginButtonClicked()
    {
        string username = usernameInputField.text;
        string password = passwordInputField.text;
        if (Login(username, password))
        {
            Debug.Log("Login successful!");
            PlayerPrefs.SetString("Name", usernameInputField.text);
            PlayerPrefs.SetFloat("LoggedIn", 1);
            SceneManager.LoadScene("App");
        }
        else
        {
            Debug.Log("Invalid username or password.");
            loginScript.SendNotification("Ugyldigt brugernavn eller adgangskode!", true);
        }
    }

    public void OnCreateAccountButtonClicked()
    {
        string username = usernameInputField.text;
        string password = passwordInputField.text;
        string email = emailInputField.text;
        CreateUser(username, password, email);
        loginScript.SendNotification("Din konto blev oprettet!", false);
        loginScript.ShowLogin();
    }
}

[System.Serializable]
public class User
{
    public string username;
    public string password;
    public string email;
    public int level;
    public int experience;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
}
