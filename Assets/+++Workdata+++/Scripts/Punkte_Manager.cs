using UnityEngine;

public class Punkte_Manager : MonoBehaviour
{
    [SerializeField] private int Z�hlerPunkte = 0;      // Ein Feld einf�gen f�r Z�hlerPunkte gleich 0
    [SerializeField] private UI_Manager ui_Manager;     // Ein Feld einf�gen f�r UI_Manager als ui_Manager
    private AudioSource M�nzeSound;


    private void Start()
    {
        Z�hlerPunkte = 0;                               // Der Z�hler soll gelich = 0
        ui_Manager.UpdatePunkteText(Z�hlerPunkte);      // Der ui_Manger soll ge-Updatet werden im Text im Z�hlerPunkte
   }
    public void Hinzuf�gen()
    {
        Z�hlerPunkte++;                                 // Der Z�hlerPunkt soll um 1 steigern
        ui_Manager.UpdatePunkteText(Z�hlerPunkte);      // Der ui_Manger soll ge-Updatet werden im Text im Z�hlerPunkte
        
    }

}
