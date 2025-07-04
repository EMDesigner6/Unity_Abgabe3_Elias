using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textZ�hlerPunkte;  // Ein Feld einf�gen als Text f�r textZ�hlerPunkte

    [SerializeField] private GameObject panelLost;          // Ein Feld einf�gen als GameObjekt f�r panelLost 
    [SerializeField] private GameObject panelWin;           // Ein Feld einf�gen als GameObjekt f�r panelWin
    [SerializeField] private GameObject panelMenu;          // Ein Feld einf�gen als GameObjekt f�r panelMenu
    [SerializeField] private GameObject panelPlay;          // Ein Feld einf�gen als GameObjekt f�r panelPlay
    [SerializeField] private GameObject panelCounter;       // Ein Feld einf�gen als GameObjekt f�r panelCounter

    [SerializeField] private Button buttonNeustartLevelW;    // Ein Feld einf�gen als Button f�r buttonNeustartLevelW
    [SerializeField] private Button buttonStartLevel;       // Ein Feld einf�gen als Button f�r buttonStartLevel
    [SerializeField] private Button buttonNeustartLevelL;   // Ein Feld einf�gen als Button f�r buttonNeustartLevelL

  //  [SerializeField] private int StartTime = 3;             // Ein Feld einf�gen ein ganz Zahr f�r StartTime gleich 3
    [SerializeField] private TextMeshProUGUI textCounter;   //Ein Feld einf�gen als TextMeshProUGUI f�r textCounter
    [SerializeField] private Player player;                   // Ein Fled einf�gen als Player f�r player

  
    
    private void Start()
    {
        ShowPanelMenu();
        //ShowPanelCounter(); // Programm ShowPanelCounter ausf�hren
        
        buttonNeustartLevelW.onClick.AddListener(NeustartLevel);        //buttonNeustartLevel geklickt wird dann soll Varaible NeustartLevel ausgef�hrt werden
        buttonStartLevel.onClick.AddListener(StartLevel);               //buttonStartLevel geklickt wird dann soll Varaible StartLevel ausgef�hrt werden
        buttonNeustartLevelL.onClick.AddListener(NeustartLevel);        //buttonNeustartLevel geklickt wird dann soll Varaible NeustartLevel ausgef�hrt werden
   
        
    }
    public void NeustartLevel()             // Eine Private Funktion f�r NeustartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Der SceneManager soll die LoadScene
    }
    public void StartLevel()
    {
        ShowPanelCounter();
        StartCoroutine(RunterZeahlen());
        StartCoroutine(PanelWeckseln());
       
    }

    public void UpdatePunkteText(int NeuPunkteZ�hler)
    {
        textZ�hlerPunkte.text = NeuPunkteZ�hler.ToString();
    }
    //----------------Panels----------------------
    public void ShowPanelLost()         // Das Progamm ShowPanelLost 
    {
        panelLost.SetActive(true);      // Der PanelLost gezeigt soll Aktivierten (Wahr)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.NichtBewegen();          // Der Player f�r Funnktion NichtBewegen() aus
    }
    public void ShowPanelWin()          // Das Progamm ShowPanelWin
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(true);       // Der PanelWin gezeigt soll Aktivierten (Wahr)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.NichtBewegen();          // Der Player f�r Funnktion NichtBewegen() aus
    }
    public void ShowPanelMenu()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten(Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten(Falsch)
        panelMenu.SetActive(true);      // Der PanelMenu gezeigt soll Aktivierten(Wahr)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.NichtBewegen();          // Der Player f�r Funnktion NichtBewegen() aus
    }
    public void ShowPanelPlay()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(true);      // Der PanelPlay gezeigt soll Aktivierten (Wahr)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.Bewegen();               // Der Player f�r Funnktion Bewegen() aus
    }
    public void ShowPanelCounter()         // Das Progamm ShowPanelCounter
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);      // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(true);  // Der PanelCounter gezeigt soll Aktivierten (Wahr)
        player.NichtBewegen();          // Der Player f�r Funnktion NichtBewegen() aus
    }
    IEnumerator RunterZeahlen() // F�rs Runter Zaehlen
    {
        textCounter.text = "3";
        Debug.Log(message: "Es");
        for (int i = 3; i > 0; i--)    // Schleife (Varriable i Gleich 3, wenn i gr��er als 0 ist , 1 wird um eins kleiner)
        {
            textCounter.text = "1";             // Der TextCounter.text ist gleich "1"
            textCounter.text = i.ToString();        // Der ui_Manger soll ge-Updatet werden im Text im textCounter
            yield return new WaitForSeconds(1f);    //Zeit um ein runter z�hlen
        }
    }
    IEnumerator PanelWeckseln() // F�rs Panle Anzeige
    {
        yield return null;
        yield return new WaitForSeconds(3f);
        ShowPanelPlay();

    }
    /*
    public void YourWinnerTime()
    {
        // die Zeit soll stoppen
        // und soll Angezeigt werden
        ShowPanelWin();
    }*/
 
}

