using TMPro;
using UnityEngine;

public class AchievementsScript : MonoBehaviour
{

    public TMP_Text[] txts;
    NotificationManager notificationManager;

    void Start()
    {
        notificationManager = GameObject.Find("NotificationManager").GetComponent<NotificationManager>();
        foreach (var item in txts)
        {
            item.text = PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Points").ToString();
        }
    }

    public void RedeemBtnClick(int id, int price)
    {
        if(PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Points") >= price)
        {
            notificationManager.SendNotification("Du har indl�st et gavekort! Du vil modtage en e-mail inden l�nge.", false);
        }
        else
        {
            notificationManager.SendMessage("Du har ikke nok point til at indl�se dette gavekort!", true);
        }
    }
}
