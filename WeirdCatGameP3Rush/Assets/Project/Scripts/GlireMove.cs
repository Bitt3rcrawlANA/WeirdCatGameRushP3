using UnityEngine;

public class GlireMove : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public Transform catTra;

    public Vector2 direction;
    public float speed;

    public bool isCoward;
    private bool found = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Flip();
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            rb.linearVelocity = new Vector2(speed, 0);
        }
        else
        {
            rb.linearVelocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.2f && currentPoint == pointB.transform)
        {
            Flip();
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.2f && currentPoint == pointA.transform)
        {
            Flip();
            currentPoint = pointB.transform;
        }
        if (found == true && isCoward == false)
        {
            Vector3 velocity = (catTra.position - transform.position).normalized;
            direction = velocity;
            rb.linearVelocity = new Vector2(direction.x, direction.y) * speed;
        }
        if (found == true && isCoward == true)
        {
            Vector3 velocity = (catTra.position + transform.position).normalized;
            direction = velocity;
            rb.linearVelocity = new Vector2(direction.x, direction.y) * speed;
        }
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Field of View Entered!");
            found = true;
        }
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
