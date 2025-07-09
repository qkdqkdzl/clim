using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCount : MonoBehaviour
{
    /// <summary>
    /// Ŭ�� ī��Ʈ�ϴ� ��ũ��Ʈ
    /// </summary>
    private int currentClick = 0;

    public void OnClickButton() // Turn, Up ��ư�� ����
    {
        currentClick++;
        Debug.Log("���� Ŭ�� ��: " + currentClick);
    }
    
    public void OnGameOver()
    {
        ClickData.Instance.SaveClickCount(currentClick);
    }
}
