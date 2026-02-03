using JetBrains.Annotations;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    float moveHorizontal;

    public Vector2 jump;
    public float jumpForce;
    public float speed;
    public bool isGrounded;

    Rigidbody2D rb2d;

    public int health;

    public GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jump = new Vector2(0.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2d.AddForce(jump * jumpForce, ForceMode2D.Force);
            isGrounded = false;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            var bulletClone = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        }
    }
    private void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(moveHorizontal * speed, rb2d.linearVelocity.y);
    }

    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }
}
