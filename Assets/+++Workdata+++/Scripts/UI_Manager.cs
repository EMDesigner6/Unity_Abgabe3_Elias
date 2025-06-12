using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Text textZählerPunkte;         // Ein Feld einfügen als Text für textZählerPunkte
    [SerializeField] private Text textZählerZeit;           // Ein Feld einfügen als Text für textZählerZeit

    [SerializeField] private GameObject panelLost;          // Ein Feld einfügen als GameObjekt für panelLost 
    [SerializeField] private GameObject panelWin;           // Ein Feld einfügen als GameObjekt für panelWin
    [SerializeField] private GameObject panelMenu;          // Ein Feld einfügen als GameObjekt für panelMenu
    [SerializeField] private GameObject panelPlay;          // Ein Feld einfügen als GameObjekt für panelPlay
    [SerializeField] private GameObject panelCounter;       // Ein Feld einfügen als GameObjekt für panelCounter

    [SerializeField] private Button buttonNeustartLevel;    // Ein Feld einfügen als Button für buttonNeustartLevel
    [SerializeField] private Button buttonStartLevel;       // Ein Feld einfügen als Button für buttonStartLevel
    private  void Start()
    {
        ShowPanelCounter(); // Programm ShowPanelCounter ausführen

        buttonNeustartLevel.onClick.AddListener(NeustartLevel);     //buttonNeustartLevel geklickt wird dann soll Varaible NeustartLevel ausgeführt werden
        buttonStartLevel.onClick.AddListener(StartLevel);           //buttonStartLevel geklickt wird dann soll Varaible StartLevel ausgeführt werden
    }

    
    public void  NeustartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void UpdatePunkteText(int NeuPunkteZähler)
    {
        textZählerPunkte.text = NeuPunkteZähler.ToString();
    }

    public void ShowPanelLost()         // Das Progamm ShowPanelLost 
    {
        panelLost.SetActive(true);      // Der PanelLost gezeigt soll Aktivierten (Wahr)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelWin()          // Das Progamm ShowPanelWin
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(true);       // Der PanelWin gezeigt soll Aktivierten (Wahr)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelMenu()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten(Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten(Falsch)
        panelMenu.SetActive(true);      // Der PanelMenu gezeigt soll Aktivierten(Wahr)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelPlay()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(true);      // Der PanelPlay gezeigt soll Aktivierten (Wahr)
        panelCounter.SetActive(false);  // Der PanelCounter gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelCounter()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);      // Der PanelPlay gezeigt soll Aktivierten (Falsch)
        panelCounter.SetActive(true);  // Der PanelCounter gezeigt soll Aktivierten (Wahr)
    }
}

