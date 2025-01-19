using UnityEngine;

public class NotificationManager : MonoBehaviour
{

    public GameObject canvas;
    public GameObject notifyPrefab;

    public void SendNotification(string message, bool isError)
    {
        GameObject canvasObj = GameObject.FindGameObjectWithTag("NotifyCanvas");
        GameObject instantiatedNotify = Instantiate(notifyPrefab, canvas.transform);

        Notification notificationScript = instantiatedNotify.GetComponent<Notification>();

        notificationScript.message = message;
        notificationScript.isError = isError;
    }
}
