using UnityEngine;


public class escuridaopp : MonoBehaviour
{
    public Transform laura;
    public float inicioEscuridao = 10f;
    public float fimEscuridao = 40f;


    private SpriteRenderer sr;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        float x = laura.position.x;


        float alpha = Mathf.InverseLerp(inicioEscuridao, fimEscuridao, x);
        alpha = Mathf.Clamp(alpha, 0.2f, 0.85f);


        Color c = sr.color;
        c.a = alpha;
        sr.color = c;
    }
}
