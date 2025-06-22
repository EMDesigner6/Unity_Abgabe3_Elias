using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textZählerPunkte;  // Ein Feld einfügen als Text für textZählerPunkte

    [SerializeField] private GameObject panelLost;          // Ein Feld einfügen als GameObjekt für panelLost 
    [SerializeField] private GameObject panelWin;           // Ein Feld einfügen als GameObjekt für panelWin
    [SerializeField] private GameObject panelMenu;          // Ein Feld einfügen als GameObjekt für panelMenu
    [SerializeField] private GameObject panelPlay;          // Ein Feld einfügen als GameObjekt für panelPlay
    [SerializeField] private GameObject panelCounter;       // Ein Feld einfügen als GameObjekt für panelCounter

    [SerializeField] private Button buttonNeustartLevelW;    // Ein Feld einfügen als Button für buttonNeustartLevelW
    [SerializeField] private Button buttonStartLevel;       // Ein Feld einfügen als Button für buttonStartLevel
    [SerializeField] private Button buttonNeustartLevelL;   // Ein Feld einfügen als Button für buttonNeustartLevelL

  //  [SerializeField] private int StartTime = 3;             // Ein Feld einfügen ein ganz Zahr für StartTime gleich 3
    [SerializeField] private TextMeshProUGUI textCounter;   //Ein Feld einfügen als TextMeshProUGUI für textCounter
    [SerializeField] private Player player;                   // Ein Fled einfügen als Player für player

  
    
    private void Start()
    {
        ShowPanelMenu();
        //ShowPanelCounter(); // Programm ShowPanelCounter ausführen
        
        buttonNeustartLevelW.onClick.AddListener(NeustartLevel);        //buttonNeustartLevel geklickt wird dann soll Varaible NeustartLevel ausgeführt werden
        buttonStartLevel.onClick.AddListener(StartLevel);               //buttonStartLevel geklickt wird dann soll Varaible StartLevel ausgeführt werden
        buttonNeustartLevelL.onClick.AddListener(NeustartLevel);        //buttonNeustartLevel geklickt wird dann soll Varaible NeustartLevel ausgeführt werden
   
        
    }
    public void NeustartLevel()             // Eine Private Funktion für NeustartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Der SceneManager soll die LoadScene
    }
    public void StartLevel()
    {
        ShowPanelCounter();
        StartCoroutine(RunterZeahlen());
        StartCoroutine(PanelWeckseln());
       
    }

    public void UpdatePunkteText(int NeuPunkteZähler)
    {
        textZählerPunkte.text = NeuPunkteZähler.ToString();
    }
    //----------------Panels----------------------
    public void ShowPanelLost()         // Das Progamm ShowPanelLost 
    {
        panelLost.SetActive(true);      // Der PanelLost gezeigt soll Aktivierten (Wahr)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.NichtBewegen();          // Der Player für Funnktion NichtBewegen() aus
    }
    public void ShowPanelWin()          // Das Progamm ShowPanelWin
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(true);       // Der PanelWin gezeigt soll Aktivierten (Wahr)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.NichtBewegen();          // Der Player für Funnktion NichtBewegen() aus
    }
    public void ShowPanelMenu()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten(Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten(Falsch)
        panelMenu.SetActive(true);      // Der PanelMenu gezeigt soll Aktivierten(Wahr)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.NichtBewegen();          // Der Player für Funnktion NichtBewegen() aus
    }
    public void ShowPanelPlay()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(true);      // Der PanelPlay gezeigt soll Aktivierten (Wahr)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
        player.Bewegen();               // Der Player für Funnktion Bewegen() aus
    }
    public void ShowPanelCounter()         // Das Progamm ShowPanelCounter
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);      // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(true);  // Der PanelCounter gezeigt soll Aktivierten (Wahr)
        player.NichtBewegen();          // Der Player für Funnktion NichtBewegen() aus
    }
    IEnumerator RunterZeahlen() // Fürs Runter Zaehlen
    {
        textCounter.text = "3";
        Debug.Log(message: "Es");
        for (int i = 3; i > 0; i--)    // Schleife (Varriable i Gleich 3, wenn i größer als 0 ist , 1 wird um eins kleiner)
        {
            textCounter.text = "1";             // Der TextCounter.text ist gleich "1"
            textCounter.text = i.ToString();        // Der ui_Manger soll ge-Updatet werden im Text im textCounter
            yield return new WaitForSeconds(1f);    //Zeit um ein runter zählen
        }
    }
    IEnumerator PanelWeckseln() // Fürs Panle Anzeige
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

