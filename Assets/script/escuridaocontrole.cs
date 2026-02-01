using UnityEngine;

public class escuridaocontrole : MonoBehaviour
{
    public Transform player;
    public float darkeningSpeed = 0.1f;

    private SpriteRenderer sr;
    private float escuridao = 0f;
    private Vector3 lastPlayerPos;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        lastPlayerPos = player.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, lastPlayerPos);

        if (distance > 0.01f)
        {
            escuridao += distance * darkeningSpeed;
            escuridao = Mathf.Clamp(escuridao, 0f, 0.85f);

            Color c = sr.color;
            c.a = escuridao;
            sr.color = c;

            lastPlayerPos = player.position;
        }
    }
}
