        using TMPro;
using UnityEngine;

public class Count : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private int totalPressCount = 0;

    public void OnButtonPressed()
    {
        //SceneManager.LoadScene(""); �� ��ȯ

        totalPressCount++;
        countText.text = $"{totalPressCount}";
    }       
}
