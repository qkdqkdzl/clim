using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("����");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("ȸ��");
        }
    }
}




