using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject infoPanel;

    void OnMouseDown()
    {
        infoPanel.SetActive(true);
    }
}