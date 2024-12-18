using TMPro;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    public GameObject[] nameTxt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameTxt = GameObject.FindGameObjectsWithTag("NameTxt");
        foreach (GameObject go in nameTxt)
        {
            go.GetComponent<TMP_Text>().text = PlayerPrefs.GetString("Name").ToUpper();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
