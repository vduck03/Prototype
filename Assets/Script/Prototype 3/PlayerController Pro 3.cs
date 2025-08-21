using UnityEngine;

public class PlayerControllerPro3 : MonoBehaviour
{
    private Rigidbody rb;
    private float jumpForce = 700;
    private float gravityModifier = 2f;
    private bool isGrounded = true;
    public bool gameOver = false;
    private Animator animator;
    public ParticleSystem explosion;
    public ParticleSystem dirt;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioSource audioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            animator.SetTrigger("Jump_trig");
            dirt.Stop();
            audioSource.PlayOneShot(jumpSound, 1f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dirt.Play();
        }else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);
            explosion.Play();
            dirt.Stop();
            audioSource.PlayOneShot(crashSound, 1.0f);
        }
    }
}
