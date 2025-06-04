using UnityEngine;

public class Punkte_Manager : MonoBehaviour
{
    [SerializeField] private int Z�hlerPunkte = 0;
    [SerializeField] private UI_Manager ui_Manager;

    // Update is called once per frame
    private void Start()
    {
        Z�hlerPunkte = 0;
        ui_Manager.UpdatePunkteText(Z�hlerPunkte);
    }
    public void Hinzuf�gen()
    {
        Z�hlerPunkte++;
        ui_Manager.UpdatePunkteText(Z�hlerPunkte);
    }
}
