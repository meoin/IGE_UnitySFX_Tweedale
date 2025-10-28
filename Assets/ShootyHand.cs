using UnityEngine;

public class ShootyHand : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float minPitch = 0.9f;
    public float maxPitch = 1.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            audioSource.pitch = Random.Range(minPitch, maxPitch);
            audioSource.PlayOneShot(clip);
        }
    }
}
