using UnityEngine;
using UnityEngine.Rendering.Universal;

public class lauraluz : MonoBehaviour
{
    public Light2D light2D;
    public float strongIntensity = 2f;

    private bool lightOn = true;

    void Start()
    {
        light2D.intensity = strongIntensity;
        light2D.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightOn = !lightOn;
            light2D.enabled = lightOn;
        }
    }
}
