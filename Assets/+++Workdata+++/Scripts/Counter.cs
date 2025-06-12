using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    // Wenn Spiel Start soll das Counter Panel angezeigt
    // Timer soll von 3 Runter Zählen
    //Und Erst danach soll das Spiel Starten (tIMER UND UND tASTWN

    [SerializeField] private TextMeshProUGUI textCounter;

    [SerializeField] private GameObject GameObecjtWithScript;
    //[SerializeField] private UI_Manager ui_Manager; // Um Scripte miteinader Verbinden

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GameObecjtWithScript.GetComponent<UI_Manager>().Start123Counter();
        GameObecjtWithScript.GetComponent<UI_Manager>().ShowPanelCounter();
        GameObecjtWithScript.GetComponent<UI_Manager>().Zahlweckseln();

        // Der ui_Manger soll ge-Updatet werden im Text im textCounter
        //ui_Manager.ShowPanelCounter();               // Der ui_Manger soll ShowPanelCounter ausführen
    }

}
