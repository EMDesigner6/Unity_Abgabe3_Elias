using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Text textZählerPunkte;
    [SerializeField] private Text textZählerZeit;

    [SerializeField] private GameObject panelLost;
    [SerializeField] private GameObject panelWin;
    [SerializeField] private GameObject panelMenu;
    [SerializeField] private GameObject panelPlay
        ;
    [SerializeField] private Button buttonNeustartLevel;
    [SerializeField] private Button buttonStartLevel;
   private  void Start()
    {
        panelLost.SetActive(false);
        panelWin.SetActive(false);
        panelMenu.SetActive(false);
        panelPlay.SetActive(false);

        buttonNeustartLevel.onClick.AddListener(NeustartLevel);
    }

    
    void NeustartLevel()
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
        panelPlay.SetActive(false);      // Der PanelPlay gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelWin()          // Das Progamm ShowPanelWin
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(true);       // Der PanelWin gezeigt soll Aktivierten (Wahr)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelMenu()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten(Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll Aktivierten(Falsch)
        panelMenu.SetActive(true);      // Der PanelMenu gezeigt soll Aktivierten(Wahr)
        panelPlay.SetActive(false);     // Der PanelPlay gezeigt soll Aktivierten (Falsch)
    }
    public void ShowPanelPlay()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll Aktivierten (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt  soll Aktivierten (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll Aktivierten (Falsch)
        panelPlay.SetActive(true);      // Der PanelPlay gezeigt soll Aktivierten (Wahr)
    }
}

