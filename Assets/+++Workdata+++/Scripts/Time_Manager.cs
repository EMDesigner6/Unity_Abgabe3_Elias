using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Time_Manager : MonoBehaviour
{
    [SerializeField] private float YourTime = 0;
    [SerializeField] private TextMeshProUGUI Z�hler;
    [SerializeField] private Text Z�hler2;


    void Start()
    {
        YourTime = 0;

     
        Debug.Log(message: "Der Zeit Z�hler z�hlt");
        
    }

 
    void Update()
    {
        YourTime += Time.deltaTime;
        Z�hler2.text = YourTime.ToString("F2") + "s";
    }
 }
    
