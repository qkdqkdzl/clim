using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBtn : MonoBehaviour
{
    // ������ ǥ���� TextMeshProUGUI ����
    public TextMeshProUGUI scoreCountText;
    public Button Scoerbtn;

    // ���� ���� (��ư�� ���� Ƚ��)
    private int currentScore = 0;

    void Start()
    {
        // ��ũ��Ʈ�� �پ��ִ� GameObject���� Button ������Ʈ�� �����ɴϴ�.
        // �� ��ũ��Ʈ�� ���ھ� ��ư ������Ʈ�� ���� �پ����� �� ����մϴ�.
        Button scoreButton = GetComponent<Button>();

        // ��ư�� �����ϸ� Ŭ�� �̺�Ʈ�� IncreaseScore �Լ��� �����մϴ�.
        if (scoreButton != null)
        {
            scoreButton.onClick.AddListener(IncreaseScore);
        }
        else
        {
            Debug.LogError("ScoreButtonHandler ��ũ��Ʈ�� Button ������Ʈ�� ���� ������Ʈ�� �����Ǿ����ϴ�!");
        }

        // ���� ���� �� ���� UI �ʱ�ȭ
        UpdateScoreUI();
    }

    /// <summary>
    /// ��ư�� Ŭ���� ������ ������ 1 ������Ű�� UI�� ������Ʈ�մϴ�.
    /// </summary>
    public void IncreaseScore()
    {
        currentScore++; // ���� 1 ����
        UpdateScoreUI(); // UI ������Ʈ
        Debug.Log("���ھ� ��ư Ŭ��! ���� ����: " + currentScore);
    }

    /// <summary>
    /// ���� UI �ؽ�Ʈ�� ������Ʈ�մϴ�.
    /// </summary>
    void UpdateScoreUI()
    {
        if (scoreCountText != null)
        {
            scoreCountText.text = "����: " + currentScore.ToString();
        }
        else
        {
            Debug.LogWarning("Score Count Text�� ������� �ʾҽ��ϴ�. UI ������Ʈ�� �� �� �����ϴ�.");
        }
    }
}
