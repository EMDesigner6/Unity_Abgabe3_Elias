using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;                  // Ein Feld für  Geschwindichkeit gelich 5
    [SerializeField] float hüpfen = 10f;                        // Ein Feld für  Hüpfen gleich 10

    private float direction = 0f;                               // Der als float definierte direction ist gleich 0

    private Rigidbody2D rb;

    [Header("BodenChecker")]

    [SerializeField] private Transform transformBodenChecker;   // Ein Feld für Transform der transformBodenChecker

    [SerializeField] private LayerMask LayerBoden;              // Ein Feld für Layermask für den LayerBoden

    [Header("Manager")]

    [SerializeField] private Punkte_Manager punkteManager;      // Ein Feld für Punkte_Manager 
    [SerializeField] private UI_Manager ui_Manager;             // Ein Feld für UI_Manager

    private bool KannBewegen = true;                            // ein bool KannBewegen gleich Wahr,

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }


    void Update()
    {
        if (KannBewegen)                                        // Eine Wenn für (KannBewegen)
        {
            direction = 0f;                                     //Zum Stoppen, Bewegungslos

            if (Keyboard.current.aKey.isPressed)                // Drücke ich die Taste A ,dann
            {
                direction = -1;                                 // Nach Links 
                Debug.Log("Nach Links");
            }

            if (Keyboard.current.dKey.isPressed)                // Drücke ich die Taste D ,dann
            {
                direction = 1;                                  // Nach Rechts 
                Debug.Log("Nach Rechts");
            }

            if (Keyboard.current.spaceKey.wasPressedThisFrame)  // Drücke ich die Leertaste ,dann
            {
                Springen();                                     // Programm Springen ausführen 
                Debug.Log("Nach Oben");
            }

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
