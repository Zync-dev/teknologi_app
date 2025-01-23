using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class CalendarItem : MonoBehaviour
{
    public int calendarItemId;

    public TMP_Text headerText;
    public TMP_Text descriptionText;
    public TMP_Text dateText;

    public Image logoImg;

    public Navbar navBarScript;

    private void Start()
    {
        navBarScript = GameObject.FindGameObjectWithTag("NavBar").GetComponent<Navbar>();
    }

    public void Initialize(string header, string description, string date, Sprite img, int itemId)
    {
        headerText.text = header;
        descriptionText.text = description;
        dateText.text = date;
        logoImg.sprite = img;

        calendarItemId = itemId;
    }

    public void ReadMoreBtnPressed()
    {
        navBarScript.CalendarChosenClick();

        GameObject CalendarChosenPageObj = GameObject.Find("Calendar_Chosen(Clone)");
        CalendarChosenPage calendarChosenPageScript = CalendarChosenPageObj.GetComponent<CalendarChosenPage>();

        calendarChosenPageScript.InstantiateItems2(calendarItemId);
    }
}
