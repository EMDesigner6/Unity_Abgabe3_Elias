using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce;

    private void OnEnable()
    {

    }

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }
}
