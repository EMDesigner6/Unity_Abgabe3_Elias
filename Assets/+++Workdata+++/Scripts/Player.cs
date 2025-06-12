using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;                  // Ein Feld einfügen für Geschwindichkeit gelich 5
    [SerializeField] float hüpfen = 10f;                        // Ein Feld einfügen für Hüpfen gleich 10

    private float direction = 0f;                               // Der als float definierte direction ist gleich 0

    private Rigidbody2D rb;

    [Header("BodenChecker")]

    [SerializeField] private Transform transformBodenChecker;   // Ein Feld einfügen für Transform der transformBodenChecker

    [SerializeField] private LayerMask LayerBoden;              // Ein Feld einfügen für Layermask für den LayerBoden

    [Header("Manager")]

    [SerializeField] private Punkte_Manager punkteManager;      // Ein Feld einfügen für Punkte_Manager 
    [SerializeField] private UI_Manager ui_Manager;             // Ein Feld einfügen für UI_Manager

    private bool KannBewegen = true;                            // ein bool einfügen name KannBewegen gleich Wahr

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }


    void Update()
    {
        if (KannBewegen)                                        // Eine Wenn für (KannBewegen)
        {
            direction = 0f;                                     //Zum Stoppen, Bewegungslos

            if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))                // Drücke ich die Taste A ,dann
            {
                direction = -1;                                 // Nach Links 
                Debug.Log("Nach Links");
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))                // Drücke ich die Taste D ,dann
            {
                direction = 1;                                  // Nach Rechts 
                Debug.Log("Nach Rechts");
            }

            if (Keyboard.current.spaceKey.wasPressedThisFrame)  // Drücke ich die Leertaste ,dann
            {
                Springen();                                     // Programm Springen ausführen 
                Debug.Log("Nach Oben");
            }

           /* if (Input.GetKey(KeyCode.Escape))
            {
                ui_Manager.ShowPanelMenu();
            }*/

            rb.linearVelocity = new Vector2(x: direction * speed, rb.linearVelocity.y);


        }
    }

    void Springen()

    {
        if (Physics2D.OverlapCircle(transformBodenChecker.position, 0.3f, LayerBoden))
        {
            rb.linearVelocity = new Vector2(x: 0, y: hüpfen);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Kollidiert mit ");               // Kommwnteierrt werden "Kolidiert mit"

        if (other.CompareTag("Punkte"))             // wenn Punkte berüht wird
        {
            Debug.Log("Münze");                     // Kommwnteiert werden "Münze"
            Destroy(other.gameObject);              // Zerstöre das Besagt Gameo
            punkteManager.Hinzufügen();             // Programm von punkteManager Hinzufügen ausführen


        }
        else if (other.CompareTag("Hindernisse"))   // Kommwnteierrt werden "Hindernisse"
        {
            ui_Manager.ShowPanelLost();             // ui:Manager soll Programm ShowPanelLost ausführen
            rb.linearVelocity = Vector2.zero;       // der rb soll gleich Vector2D Null
            KannBewegen = false;                    // KannBewegen ist gelich Falsch

        }
        else if (other.CompareTag("Diamanten"))     // wenn Punkte berüht wird
        {
            Debug.Log("Diamanten");                 // Kommwnteiert werden "Münze"
            Destroy(other.gameObject);              // Zerstöre das Besagt Gameo
            punkteManager.Hinzufügen();             // Programm von punkteManager Hinzufügen ausführen

        }

    }
    void BevorStarte()
    {

    }
}
/*Für PfeilTasten Steuerung
    void Update()
    {
        // Detect Up Arrow
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow Pressed");
        }

        // Detect Down Arrow
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow Pressed");
        }

        // Detect Left Arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Pressed");
        }

        // Detect Right Arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow Pressed");
        }
    }
} */
