using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStairCheck : MonoBehaviour
{
    private bool isOnBlock = false;
    private bool gameOverTriggered = false;
    
    //  [�ν����Ϳ� ǥ��] ���� ���� �ؽ�Ʈ UI �����
    [SerializeField] private TextMeshProUGUI gameOverText;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name.Contains("Block"))
        {
            isOnBlock = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Contains("Block"))
        {
            isOnBlock = false;
        }
    }

    void Update()
    {
        if (!isOnBlock && !gameOverTriggered)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        gameOverTriggered = true;

        //  �ֿܼ��� ���
        Debug.Log("���� ����! 'play' ������Ʈ�� Block ���� ����.");

        //  UI �ؽ�Ʈ�� ����Ǿ� ������ ȭ�鿡 ǥ��
        if (gameOverText != null)
        {
            gameOverText.text = "���� ����!";
            gameOverText.enabled = true;
        }
        else
        {
            Debug.LogWarning("gameOverText UI�� ������� �ʾҽ��ϴ�!");
        }
    }
}
