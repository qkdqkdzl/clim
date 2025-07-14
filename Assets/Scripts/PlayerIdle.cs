using UnityEngine;

public class PlayIdle : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
            if (animator == null)
                Debug.LogError($"[{gameObject.name}] Animator ����. ���� ���� Ȯ�� ���.");
        }
    }

    public void PlayerIdleAnim()
    {
        if (animator != null)
        {
            animator.CrossFade("Idle", 0.1f);
        }
    }
}
