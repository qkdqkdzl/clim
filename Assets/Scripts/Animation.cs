using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator animator;
    private bool hasFallen = false;

    [Header("Ÿ�̸� ����")]
    public float timerDuration = 5f; // ���÷� 5��
    private float timer;

    void Start()
    {
        animator = GetComponent<Animator>();
        timer = timerDuration;
    }

    void Update()
    {
        if (hasFallen) return;

        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            hasFallen = true;
            animator.SetTrigger("StartFalling");
        }
    }

    //      �� �Լ��� falling �ִϸ��̼� ������ �����ӿ� Animation Event�� �����ؾ� ��
    public void OnFallAnimationEnd()
    {
        Destroy(gameObject); // ĳ���� ����
    }
}
