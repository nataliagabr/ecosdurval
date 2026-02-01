using UnityEngine;
using UnityEngine.Rendering.Universal;

public class lauraluz : MonoBehaviour
{
    public Light2D light2D;

    public AudioSource estaloAudio;
    public AudioSource rangidoAudio;

    private bool lightOn = true;

    void Start()
    {
        light2D.enabled = true;

        rangidoAudio.Stop();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightOn = !lightOn;

            estaloAudio.Play();

            if (lightOn)
            {
                light2D.enabled = true;
                rangidoAudio.Stop();
            }
            else
            {
                light2D.enabled = false;
                rangidoAudio.Play();
            }
        }
    }
}
