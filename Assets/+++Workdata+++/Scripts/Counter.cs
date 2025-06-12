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
    [SerializeField] private int StartTime = 3;
    [SerializeField] private GameObject GameObecjtWithScript;
    //[SerializeField] private UI_Manager ui_Manager; // Um Scripte miteinader Verbinden

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartTime = 3;
        StartCoroutine(routine: PanelWeckseln()); 
        StartCoroutine(routine: RunterZeahlen());
        //ui_Manager.UpdatePunkteText(StartTime);
        GameObecjtWithScript.GetComponent<UI_Manager>().ShowPanelCounter();
        // Der ui_Manger soll ge-Updatet werden im Text im textCounter
        //ui_Manager.ShowPanelCounter();               // Der ui_Manger soll ShowPanelCounter ausführen
    }

    IEnumerator PanelWeckseln() // Fürs Panle Anzeige
    {
        yield return null;
        yield return new WaitForSeconds(3f);
        //ui_Manager.ShowPanelPlay();
    }

    IEnumerator RunterZeahlen() // Fürs Runter Zaehlen
    {

        for (int i = 3; i < 0; i--)   // Schleife (Varriable i Gleich 0, wenn i kleiner als 5 ist , 1 wird ums 1 erhöht)
                                      // Definiren; Vergleiech; Ausführung
        {
            i = StartTime;
            
            yield return new WaitForSeconds(1f);            // Wichtig das muss bei IEnumerator drin sein
            //ui_Manager.UpdatePunkteText(i);                 
        }
        Debug.Log(message: "Counter-Schelife zu Ende");

    }
}
