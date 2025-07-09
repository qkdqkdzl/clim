using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EndGame : MonoBehaviour
{
    [SerializeField] private Button toMenuBtn;         // �̵� ��ư
    [SerializeField] private GameObject buttonObject;  // ��ư ��ü ������Ʈ

    

    private void Start()
    {
        if (toMenuBtn != null)
        {
            toMenuBtn.onClick.AddListener(GoToMenu);
            buttonObject.SetActive(false); // ���� �� ��ư ����
        }
    }

    // Ÿ�̸� ���� �� ȣ��� �Լ�
    public void ShowButton()
    {
        buttonObject.SetActive(true);
    }

    // ��ư Ŭ�� �� Menu ������ �̵�
    public void GoToMenu()
    {
        Debug.Log("Menu ������ �̵��մϴ�.");
        SceneManager.LoadScene("Menu");
    }
}
