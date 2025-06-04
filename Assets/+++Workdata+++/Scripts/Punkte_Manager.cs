using UnityEngine;

public class Punkte_Manager : MonoBehaviour
{
    [SerializeField] private int ZählerPunkte = 0;
    [SerializeField] private UI_Manager ui_Manager;

    // Update is called once per frame
    private void Start()
    {
        ZählerPunkte = 0;
        ui_Manager.UpdatePunkteText(ZählerPunkte);
    }
    public void Hinzufügen()
    {
        ZählerPunkte++;
        ui_Manager.UpdatePunkteText(ZählerPunkte);
    }
}
