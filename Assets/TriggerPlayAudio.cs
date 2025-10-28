using UnityEngine;

public class TriggerPlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) 
    {
        audioSource.PlayOneShot(clip);
    }
}
