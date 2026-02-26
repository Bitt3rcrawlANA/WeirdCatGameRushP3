using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class Birds : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform cat;
    public float speed = 2f;
    Vector2 direction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cat)
        {
            Vector3 moveDirection = (cat.position - transform.position).normalized;
            direction = moveDirection;
        }
    }

    private void FixedUpdate()
    {
        if (cat)
        {
            rb.linearVelocity = new Vector2(direction.x, direction.y) * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Field of View Entered!");
    }

}
