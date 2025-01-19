using TMPro;
using UnityEngine;
using static CalendarPage;
using UnityEngine.UI;
using static UnityEditor.Progress;
using Unity.VisualScripting;

public class CalendarChosenPage : MonoBehaviour
{
    public int chosenPageId;

    public TMP_Text headerText;
    public TMP_Text descriptionText;
    public TMP_Text informationText;

    public Image logoImg;

    public ItemDataList itemDataList;

    public void InstantiateItems(int i)
    {
        chosenPageId = i;

        headerText.text = itemDataList.items[i].header;
        descriptionText.text = itemDataList.items[i].description;
        informationText.text = $"Dato: {itemDataList.items[i].date}\nLokation: {itemDataList.items[i].location}\nPris: {itemDataList.items[i].price}";

        logoImg.sprite = itemDataList.items[i].largeImg;
    }

    public void TilmeldBtn()
    {

    }
}
