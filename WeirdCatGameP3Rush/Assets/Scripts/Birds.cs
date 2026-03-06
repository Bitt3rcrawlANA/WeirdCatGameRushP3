using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class Birds : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform catTra;
    public float speed = 2f;
    Vector2 direction;
    private bool found = false;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (found == true)
        {
            Vector3 moveDirection = (catTra.position - transform.position).normalized;
            direction = moveDirection;
            rb.linearVelocity = new Vector2(direction.x, direction.y) * speed;
        }
    }

    private void FixedUpdate()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Field of View Entered!");
            found = true;
        }
    }

}
