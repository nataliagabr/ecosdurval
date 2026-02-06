using UnityEngine;

public class lauraataque : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    public bool isGrounded; 
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Atacar();
        }

        AtualizarEstadosDoAr();
    }

    void Atacar()
    {
        if (isGrounded)
        {
            anim.SetTrigger("ataqueID");
        }
        else
        {
            anim.SetTrigger("atirandoP");
        }
    }

    void AtualizarEstadosDoAr()
    {
        if (rb.linearVelocity.y > 0.1f)
        {
            anim.SetBool("pulando", true);
            anim.SetBool("caindo", false);
        }
        else if (rb.linearVelocity.y < -0.1f)
        {
            anim.SetBool("pulando", false);
            anim.SetBool("caindo", true);
        }
        else
        {
            anim.SetBool("pulando", false);
            anim.SetBool("caindo", false);
        }
    }
}

