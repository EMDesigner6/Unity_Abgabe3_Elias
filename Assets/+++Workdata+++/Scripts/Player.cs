using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;                  // Ein Feld f�r  Geschwindichkeit gelich 5
    [SerializeField] float h�pfen = 10f;                        // Ein Feld f�r  H�pfen gleich 10

    private float direction = 0f;                               // Der als float definierte direction ist gleich 0

    private Rigidbody2D rb;

    [Header("BodenChecker")]

    [SerializeField] private Transform transformBodenChecker;   // Ein Feld f�r Transform der transformBodenChecker

    [SerializeField] private LayerMask LayerBoden;              // Ein Feld f�r Layermask f�r den LayerBoden

    [Header("Manager")]

    [SerializeField] private Punkte_Manager punkteManager;      // Ein Feld f�r Punkte_Manager 
    [SerializeField] private UI_Manager ui_Manager;             // Ein Feld f�r UI_Manager

    private bool KannBewegen = true;                            // ein bool KannBewegen gleich Wahr,

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }


    void Update()
    {
        if (KannBewegen)                                        // Eine Wenn f�r (KannBewegen)
        {
            direction = 0f;                                     //Zum Stoppen, Bewegungslos

            if (Keyboard.current.aKey.isPressed)                // Dr�cke ich die Taste A ,dann
            {
                direction = -1;                                 // Nach Links 
                Debug.Log("Nach Links");
            }

            if (Keyboard.current.dKey.isPressed)                // Dr�cke ich die Taste D ,dann
            {
                direction = 1;                                  // Nach Rechts 
                Debug.Log("Nach Rechts");
            }

            if (Keyboard.current.spaceKey.wasPressedThisFrame)  // Dr�cke ich die Leertaste ,dann
            {
                Springen();                                     // Programm Springen ausf�hren 
                Debug.Log("Nach Oben");
            }

            rb.linearVelocity = new Vector2(x: direction * speed, rb.linearVelocity.y);
        }
    }

    void Springen()

    {
        if (Physics2D.OverlapCircle(transformBodenChecker.position, 0.3f, LayerBoden))
        {
            rb.linearVelocity = new Vector2(x: 0, y: h�pfen);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Kollidiert mit ");               // Kommwnteierrt werden "Kolidiert mit"

        if (other.CompareTag("Punkte"))             // wenn Punkte ber�ht wird
        {
            Debug.Log("M�nze");                     // Kommwnteiert werden "M�nze"
            Destroy(other.gameObject);              // Zerst�re das Besagt Gameo
            punkteManager.Hinzuf�gen();             // Programm von punkteManager Hinzuf�gen ausf�hren


        }
        else if (other.CompareTag("Hindernisse"))   // Kommwnteierrt werden "Hindernisse"
        {
            ui_Manager.ShowPanelLost();             // ui:Manager soll Programm ShowPanelLost ausf�hren
            rb.linearVelocity = Vector2.zero;       // der rb soll gleich Vector2D Null
            KannBewegen = false;                    // KannBewegen ist gelich Falsch

        }
        else if (other.CompareTag("Diamanten"))     // wenn Punkte ber�ht wird
        {
            Debug.Log("Diamanten");                 // Kommwnteiert werden "M�nze"
            Destroy(other.gameObject);              // Zerst�re das Besagt Gameo
            punkteManager.Hinzuf�gen();             // Programm von punkteManager Hinzuf�gen ausf�hren

        }

    }
    void BevorStarte()
    {

    }
}
