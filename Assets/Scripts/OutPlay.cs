using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStairCheck : MonoBehaviour
{
    private bool isOnBlock = false;
    private bool gameOverTriggered = false;
    
    //  [인스펙터에 표시] 게임 오버 텍스트 UI 연결용
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

        //  콘솔에도 출력
        Debug.Log("게임 오버! 'play' 오브젝트가 Block 위에 없음.");

        //  UI 텍스트가 연결되어 있으면 화면에 표시
        if (gameOverText != null)
        {
            gameOverText.text = "게임 오버!";
            gameOverText.enabled = true;
        }
        else
        {
            Debug.LogWarning("gameOverText UI가 연결되지 않았습니다!");
        }
    }
}
