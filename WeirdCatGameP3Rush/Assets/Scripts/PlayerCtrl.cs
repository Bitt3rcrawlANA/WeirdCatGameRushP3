using JetBrains.Annotations;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    float moveHorizontal;
    public float speed;
    Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(moveHorizontal * speed, rb2d.linearVelocity.y);
    }
}
