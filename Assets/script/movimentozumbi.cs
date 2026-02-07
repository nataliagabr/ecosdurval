using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 2f;
    public float distanciaMinima = 0.5f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        float distancia = Vector2.Distance(transform.position, player.position);

        if (distancia > distanciaMinima)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }

        // virar sprite
        if (player.position.x > transform.position.x)
            transform.localScale = new Vector3(1, 1, 1);
        else
            transform.localScale = new Vector3(-1, 1, 1);
    }
}