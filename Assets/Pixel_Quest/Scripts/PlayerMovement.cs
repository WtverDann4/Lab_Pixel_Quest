
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer; 
    // Start is called before the first frame update
     void Start()

    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        if (xInput > 0) { _spriteRenderer.flipX = true; }
        else if (xInput < 0) { _spriteRenderer.flipX = false; }
            rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }
}
