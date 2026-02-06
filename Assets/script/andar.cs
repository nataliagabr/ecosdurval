using UnityEngine;

public class laura : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    public GameObject ataque; // AGORA É "ataque"

    private Rigidbody2D rb;
    private Animator anim;

    private float moveInput;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // começa com o ataque desligado
        if (ataque != null)
            ataque.SetActive(false);
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        // ANDAR
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);
        anim.SetBool("andando", moveInput != 0);

        // VIRAR SPRITE
        if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        // PULAR
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            anim.SetBool("pulando", true);
            isGrounded = false;
        }

        // PULANDO / CAINDO
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

        // ATIRAR (tecla X)
        if (Input.GetKeyDown(KeyCode.X))
        {
            Atirar();
        }
    }

    void Atirar()
    {
        if (isGrounded)
            anim.SetTrigger("ataqueID");
        else
            anim.SetTrigger("atirandoP");
    }

    // ===== EVENTOS DA ANIMAÇÃO =====
    public void AtivarAtaque()
    {
        if (ataque != null)
            ataque.SetActive(true);
    }

    public void DesativarAtaque()
    {
        if (ataque != null)
            ataque.SetActive(false);
    }

    // DETECTAR CHÃO
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("caindo", false);
        }
    }
}
