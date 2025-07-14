using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStairCheck : MonoBehaviour
{
    public LayerMask groundLayer; // Block�� �ִ� ���̾ üũ
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
            // �������� ����
            rb.gravityScale = 3f; // ������
        }
        else
        {
            // ��� ���� ��
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, 0); // ���߰�
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, checkDistance, groundLayer);
        Debug.DrawRay(transform.position, Vector2.down * checkDistance, Color.red); // ����׿�
        return hit.collider != null;
    }
}
