using UnityEngine;

public class Birds : MonoBehaviour
{
    public GameObject Cat;
    Vector2 direction;
    public float speed = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth enemy = collision.gameObject.GetComponent<BoxCollider2D>();
        Debug.Log("Field of View Entered!");
        if (other.gameObject.tag == ""Player")
    }

}
