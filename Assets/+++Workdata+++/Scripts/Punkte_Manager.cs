using UnityEngine;

public class Punkte_Manager : MonoBehaviour
{
    [SerializeField] private int ZählerPunkte = 0;      // Ein Feld einfügen für ZählerPunkte gleich 0
    [SerializeField] private UI_Manager ui_Manager;     // Ein Feld einfügen für UI_Manager als ui_Manager
    private AudioSource MünzeSound;


    private void Start()
    {
        ZählerPunkte = 0;                               // Der Zähler soll gelich = 0
        ui_Manager.UpdatePunkteText(ZählerPunkte);      // Der ui_Manger soll ge-Updatet werden im Text im ZählerPunkte
   }
    public void Hinzufügen()
    {
        ZählerPunkte++;                                 // Der ZählerPunkt soll um 1 steigern
        ui_Manager.UpdatePunkteText(ZählerPunkte);      // Der ui_Manger soll ge-Updatet werden im Text im ZählerPunkte
        
    }

}
