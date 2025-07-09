using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{    
    public Button scenesBtn;


    private void Start()
    {
        //���� Start()���� ��ư �����ʸ� �߰��Ѵٸ�(������ ����� ��1)
        if (scenesBtn != null)
        {
            scenesBtn.onClick.AddListener(SceneUpdate);
        }
    }

    // �� �Լ��� ��ư Ŭ�� �� ����� �Լ��Դϴ�.
    public void SceneUpdate()
    {
        Debug.Log("SceneUpdate �Լ� ����! play �� �ε�.");
        SceneManager.LoadScene("play");
    }   
}
