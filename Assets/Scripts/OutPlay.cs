using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStairCheck : MonoBehaviour
{
    public LayerMask groundLayer; // Block이 있는 레이어만 체크
    public float checkDistance = 0.1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool isGrounded = IsGrounded();

        if (!isGrounded)
        {
            // 떨어지는 로직
            rb.gravityScale = 3f; // 떨어짐
        }
        else
        {
            // 블록 위일 때
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, 0); // 멈추게
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, checkDistance, groundLayer);
        Debug.DrawRay(transform.position, Vector2.down * checkDistance, Color.red); // 디버그용
        return hit.collider != null;
    }
}
