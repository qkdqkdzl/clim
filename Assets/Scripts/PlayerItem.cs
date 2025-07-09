using TMPro;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    // === UI Text ������ ===
    public TextMeshProUGUI coinCountText;  // ���� ī��Ʈ�� ǥ���� UI �ؽ�Ʈ
    public TextMeshProUGUI appleCountText; // ��� ī��Ʈ�� ǥ���� UI �ؽ�Ʈ

    // === ī��Ʈ ������ ===
    private int coinCount = 0;  // ���� ���� ����
    private int appleCount = 0; // ���� ��� ����

    void Start()
    {
        // ���� ���� �� UI �ؽ�Ʈ �ʱ�ȭ
        UpdateCoinCountUI();
        UpdateAppleCountUI();
    }

    // Ʈ���� �浹 ���� �Լ�
    void OnTriggerEnter2D(Collider2D other)
    {
        // �浹�� ������Ʈ�� �±� Ȯ��
        if (other.CompareTag("Coin"))
        {
            // ������ �Ծ��� �� ��� ī��Ʈ ����
            AddApple(); // <--- ����: ������ ������ ����� ����
            Destroy(other.gameObject); // ���� ���� ������Ʈ �ı�
            Debug.Log("������ ȹ���߽��ϴ�! (��� ����) ���� ���: " + appleCount);
        }
        else if (other.CompareTag("Apple"))
        {
            // ����� �Ծ��� �� ���� ī��Ʈ ����
            AddCoin(); // <--- ����: ����� ������ ������ ����
            Destroy(other.gameObject); // ���� ��� ������Ʈ �ı�
            Debug.Log("����� ȹ���߽��ϴ�! (���� ����) ���� ����: " + coinCount);
        }
    }

    // === ���� ���� �Լ��� ===
    public void AddCoin(int amount = 1) // �⺻������ 1���� �߰�, �ٸ� ������ �����ϰ�
    {
        coinCount += amount;
        UpdateCoinCountUI(); // UI ������Ʈ
    }

    // ���� ī��Ʈ UI ������Ʈ �Լ�
    void UpdateCoinCountUI()
    {
        if (coinCountText != null)
        {
            coinCountText.text = "����: " + coinCount.ToString();
        }
    }

    // === ��� ���� �Լ��� ===
    public void AddApple(int amount = 1) // �⺻������ 1���� �߰�, �ٸ� ������ �����ϰ�
    {
        appleCount += amount;
        UpdateAppleCountUI(); // UI ������Ʈ
    }

    // ��� ī��Ʈ UI ������Ʈ �Լ�
    void UpdateAppleCountUI()
    {
        if (appleCountText != null)
        {
            appleCountText.text = "���: " + appleCount.ToString();
        }
    }
}

                
