using UnityEngine;
using UnityEngine.InputSystem;

public class Sound : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Keyboard.current.spaceKey.wasPressedThisFrame)             // wenn Punkte berüht wird
        {

            audioSource.Play();


        }
    }
}
