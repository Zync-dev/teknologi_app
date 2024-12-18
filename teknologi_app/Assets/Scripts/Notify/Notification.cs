using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
    public bool isError;
    public string message;
    public Sprite[] sprites;
    public Image icons;

    void Start()
    {
        if(isError)
        {
            icons.sprite = sprites[1];
        } else
        {
            icons.sprite = sprites[0];
        }

        this.gameObject.GetComponentInChildren<TMP_Text>().text = message;
    }

    public void DestroyNotify()
    {
        Destroy(this.gameObject);
    }
}
