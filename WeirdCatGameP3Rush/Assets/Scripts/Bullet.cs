using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rbBullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbBullet = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbBullet.linearVelocity = new Vector2(speed, 0);

        rbBullet.AddForce(rbBullet.linearVelocity, (ForceMode2D.Force));
    }

}
