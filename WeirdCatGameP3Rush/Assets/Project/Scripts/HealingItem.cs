using UnityEngine;

public class HealingItem : MonoBehaviour
{

    
    public Rigidbody2D rb2d;
    public int heal = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerCtrl playerCtrl = collision.gameObject.GetComponent<PlayerCtrl>();
        if (playerCtrl.gameObject.tag == "Player")
        {
            playerCtrl.ChangeHealth(heal);
            Destroy(gameObject);
        }
    }
}
