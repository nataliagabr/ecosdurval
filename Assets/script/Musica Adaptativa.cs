using UnityEngine;

public class ZombieAudio : MonoBehaviour
{
    public AudioClip gemido;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = gemido;

        // variação pra não ficar repetitivo
        audioSource.pitch = Random.Range(0.9f, 1.1f);

        audioSource.Play();
    }
}