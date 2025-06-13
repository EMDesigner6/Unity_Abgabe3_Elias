using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Time_Manager : MonoBehaviour
{
    [SerializeField] private float YourTime = 0;
    [SerializeField] private TextMeshProUGUI Zaehler;
    private bool isCounterDone;
  
    void Start()
    {
       

        StartCoroutine(routine: ShowDebug());
        isCounterDone = false;                  // Der isCounterDone ist gleich false
       
    }
    private void Update()
    {


        if (isCounterDone == true)     // wenn isCounterDone gleich true ist
        {                               //dann
            YourTime += Time.deltaTime;         // Soll der Timer zählen
            Zaehler.text = YourTime.ToString("F2") + "s";       // In Zaehler.text gleich YourTime im String plus  "s"ekunden
        }
    }


    IEnumerator ShowDebug() // Funktion anlegen fürs(Warten)
                            
    {
        yield return null;                            // Warten für einen Frame, Null
        yield return new WaitForSeconds(3f);          // Warte für 3 Sekunden
        isCounterDone = true;                         // Der istCounterDone ist gleich true
   
    }
}
    
