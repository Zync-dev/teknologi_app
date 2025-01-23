using TMPro;
using UnityEngine;
using static CalendarPage;

public class AchievementsScript : MonoBehaviour
{

    public TMP_Text[] pointTxts;
    public TMP_Text lvltxt;
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

    public TMP_Text finishedLessons;
    void Start()
    {
        notificationManager = GameObject.Find("NotificationManager").GetComponent<NotificationManager>();
        foreach (var item in pointTxts)
        {
            item.text = PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Points").ToString();
        }
        lvltxt.text = Mathf.Floor((PlayerPrefs.GetInt($"{PlayerPrefs.GetInt("Name")}-Exp")/100)).ToString();
        if(PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Finished_Lessons") == 1)
        {
            finishedLessons.text = PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Finished_Lessons").ToString() + " LEKTION";
        } else
        {
            finishedLessons.text = PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Finished_Lessons").ToString() + " LEKTIONER";
        }
    }
}
