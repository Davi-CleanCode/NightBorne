using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded) {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.contacts[0].normal.y > 0.5f) {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        isGrounded = false;
    }
}