using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Time_Manager : MonoBehaviour
{
    [SerializeField] private float YourTime = 0;
    [SerializeField] private TextMeshProUGUI Zähler;
    [SerializeField] private Text Zähler2;


    void Start()
    {
        YourTime = 0;

     
        Debug.Log(message: "Der Zeit Zähler zählt");
        
    }

 
    void Update()
    {
        YourTime += Time.deltaTime;
        Zähler2.text = YourTime.ToString("F2") + "s";
    }
 }
    
