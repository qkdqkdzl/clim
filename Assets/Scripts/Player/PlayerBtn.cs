
using UnityEngine;

public class PlayerBtn : MonoBehaviour
{

    public GameObject gameOverMessage;   // Canvas ���� "���ӿ���" UI ������Ʈ
    public LayerMask blockLayer;         // Block ���̾ üũ
    
    /// <summary>
    /// ��ư ������ �̵���ų ��ǥ ��
    /// </summary>
    public void OnUpButton()
    {
        transform.position += new Vector3(-1.286f, 0.599f, 0f);
    }
        
    public void OnTrunButton()
    {
        transform.position += new Vector3(1.264f, 0.599f, 0f);              
    }
    
}

