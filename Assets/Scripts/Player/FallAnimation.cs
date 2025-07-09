using System;
using UnityEngine;

public class FallAnim    : MonoBehaviour
{
    private Animator animator; 
    private bool hasPlayedFallAnim = false;             
    public float gravity = -9.8f;        // �߷� ���ӵ�
    public float rayDistance = 10f;     // �ٴ� üũ �Ÿ�
    public LayerMask blockLayer;         //  ���⼭ Block ���̾ ����

    private float verticalSpeed = 0f;
    private bool isFalling = false;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    void Update()
    {
        if (!isFalling)

        {
            if (!IsOnBlock())
            {
                isFalling = true;
                verticalSpeed = 0f;

                if (!hasPlayedFallAnim) // �߰���
                {
                    animator.SetTrigger("StartFalling"); // �߰���
                    hasPlayedFallAnim = true; // �߰���
                }
            }
            

        }
        else
        {
            verticalSpeed += gravity * Time.deltaTime;
            transform.position += new Vector3(0, verticalSpeed * Time.deltaTime, 0);

            if (transform.position.y < -10f)
            {
                Debug.Log("Game Over");
                // GameOver ó�� �ڵ� �ֱ�
            }
        }
    }

    bool IsOnBlock()
    {
        //  blockLayer�� ����� Block ���̾ üũ
        return Physics.Raycast(transform.position, Vector3.down, rayDistance, blockLayer);
        

    }

    // (����) Scene���� ����׿� �� �����ֱ�
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayDistance);
    }

    public void OnFallAnimationEnd() // �߰���
    {
        Destroy(gameObject); // �߰���
    }
}

