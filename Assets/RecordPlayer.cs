using UnityEngine;

public class RecordPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
        if (audioSource.isPlaying)
        {
            Debug.Log("Pausing");
            audioSource.Pause();
            anim.speed = 0f;
        }
        else 
        {
            Debug.Log("Unpausing");
            audioSource.UnPause();
            anim.speed = 1f;
        }
    }
}
