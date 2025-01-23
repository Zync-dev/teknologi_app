using TMPro;
using UnityEngine;

public class AchievementsScript : MonoBehaviour
{

    public TMP_Text[] txts;
    NotificationManager notificationManager;

    //PointsPanel
    public GameObject pointsPanel;

    public void OpenShopBtn()
    {
        pointsPanel.SetActive(true);
    }
    public void BackBtn()
    {
        pointsPanel.SetActive(false);
    }
    public void RedeemBtnClick(int price)
    {
        if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Points") >= price)
        {
            notificationManager.SendNotification("Du har indløst et gavekort! Du vil modtage en e-mail inden længe.", false);
        }
        else
        {
            notificationManager.SendNotification("Du har ikke nok point til at indløse dette gavekort!", true);
        }
    }

    void Start()
    {
        notificationManager = GameObject.Find("NotificationManager").GetComponent<NotificationManager>();
        foreach (var item in txts)
        {
            item.text = PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Points").ToString();
        }
    }
}
