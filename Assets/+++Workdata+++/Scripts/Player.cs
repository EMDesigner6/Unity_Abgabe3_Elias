using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;                  // Ein Feld einf�gen f�r Geschwindichkeit gelich 5
    [SerializeField] float h�pfen = 10f;                        // Ein Feld einf�gen f�r H�pfen gleich 10

    private float direction = 0f;                               // Der als float definierte direction ist gleich 0

    private Rigidbody2D rb;                                     // Der als private definierte Rigidbody ist rb

    [Header("BodenChecker")]

    [SerializeField] private Transform transformBodenChecker;   // Ein Feld einf�gen f�r Transform der transformBodenChecker

    [SerializeField] private LayerMask LayerBoden;              // Ein Feld einf�gen f�r Layermask f�r den LayerBoden

    [Header("Manager")]

    [SerializeField] private Punkte_Manager punkteManager;      // Ein Feld einf�gen f�r Punkte_Manager 
    [SerializeField] private UI_Manager ui_Manager;             // Ein Feld einf�gen f�r UI_Manager

    private bool KannBewegen = true;                            // ein bool einf�gen name KannBewegen gleich Wahr

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }


    void Update()
    {
        if (KannBewegen)                                        // Eine Wenn f�r (KannBewegen)
        {
            direction = 0f;                                     //Zum Stoppen, Bewegungslos

            if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))                // Dr�cke ich die Taste A ,dann
            {
                direction = -1;                                 // Nach Links 
            
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))                // Dr�cke ich die Taste D ,dann
            {
                direction = 1;                                  // Nach Rechts 
               
            }

            if (Keyboard.current.spaceKey.wasPressedThisFrame)  // Dr�cke ich die Leertaste ,dann
            {
                Springen();                                     // Programm Springen ausf�hren 
            }else 
            if (Keyboard.current.hKey.isPressed)
            {
                NichtBewegen();
                ui_Manager.ShowPanelMenu();
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
            rb.linearVelocity = Vector2.zero;       // der rb soll gleich Vector2D Null [Stoppen]
            ui_Manager.ShowPanelWin(); 
        }

    }
    public void NichtBewegen()
    {
        KannBewegen = false;
        new Vector2(x: 0, y: 0);
    }
    public void Bewegen()
    {
        KannBewegen = true;
    }
}
/*F�r PfeilTasten Steuerung
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
