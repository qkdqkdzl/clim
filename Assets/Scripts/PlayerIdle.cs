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
                Debug.LogError($"[{gameObject.name}] Animator 없음. 계층 구조 확인 요망.");
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
