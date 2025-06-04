using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textZählerPunkte;

    [SerializeField] private GameObject panelLost;
    [SerializeField] private GameObject panelWin;
    [SerializeField] private GameObject panelMenu;

    [SerializeField] private Button buttonNeustartLevel;
   private  void Start()
    {
        panelLost.SetActive(false);
        panelWin.SetActive(false);
        panelMenu.SetActive(false);

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
        panelLost.SetActive(true);      // Der PanelLost gezeigt soll (Richtig)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll (Falsch)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll (Richtig)
    }
    public void ShowPanelWin()          // Das Progamm ShowPanelWin
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll (Falsch)
        panelWin.SetActive(true);       // Der PanelWin gezeigt soll (Richtig)
        panelMenu.SetActive(false);     // Der PanelMenu gezeigt soll (Falsch)
    }
    public void ShowPanelMenu()         // Das Progamm ShowPanelMenu
    {
        panelLost.SetActive(false);     // Der PanelLost gezeigt soll (Falsch)
        panelWin.SetActive(false);      // Der PanelWin gezeigt soll (Falsch)
        panelMenu.SetActive(true);      // Der PanelMenu gezeigt soll (Richtig)
    }
}
