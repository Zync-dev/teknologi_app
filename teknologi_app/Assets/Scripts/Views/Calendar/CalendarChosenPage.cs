using TMPro;
using UnityEngine;
using static CalendarPage;
using UnityEngine.UI;
using static UnityEditor.Progress;
using Unity.VisualScripting;
using UnityEngine.UI;

public class CalendarChosenPage : MonoBehaviour
{
    public int chosenPageId;

    public TMP_Text headerText;
    public TMP_Text descriptionText;
    public TMP_Text informationText;

    public Button tilmeldBtn;

    public Image logoImg;

    public ItemDataList itemDataList;

    bool signedUp = false;

    NotificationManager notificationManager;

    private void Start()
    {
        notificationManager = GameObject.Find("NotificationManager").GetComponent<NotificationManager>();

        CheckIfAlreadySignedUp();
    }

    public void InstantiateItems(int i)
    {
        chosenPageId = i;

        headerText.text = itemDataList.items[i].header;
        descriptionText.text = itemDataList.items[i].description;
        informationText.text = $"Dato: {itemDataList.items[i].date}\nLokation: {itemDataList.items[i].location}\nPris: {itemDataList.items[i].price} kr.";

        logoImg.sprite = itemDataList.items[i].largeImg;
    }

    void CheckIfAlreadySignedUp()
    {
        if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}") == 1)
        {
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().text = "Afmeld".ToUpper();
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().color = Color.red;
            tilmeldBtn.gameObject.GetComponent<Image>().color = new Color32(225, 225, 225, 255);
            signedUp = true;
        } else if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}") == 0)
        {
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().text = "Tilmeld".ToUpper();
            tilmeldBtn.gameObject.GetComponentInChildren<TMP_Text>().color = Color.black;
            tilmeldBtn.gameObject.GetComponent<Image>().color = new Color32(131, 162, 137, 255);
            signedUp = false;
        }
    }

    public void TilmeldBtn()
    {
        if(!signedUp)
        {
            notificationManager.SendNotification("Du har tilmeldt dig aktiviteten!", false);
            PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}", 1);
            CheckIfAlreadySignedUp();
        } 
        else if (signedUp)
        {
            notificationManager.SendNotification("Du har afmeldt dig aktiviteten!", true);
            PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}", 0);
            CheckIfAlreadySignedUp();
        }

        print(PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Activity-{chosenPageId}"));
        PlayerPrefs.Save();
    }
}
