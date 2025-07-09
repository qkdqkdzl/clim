using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���忡 ����� �����ϰ� ����ִ� �ڵ�
/// </summary>

public class BlockRandom : MonoBehaviour
{
        
    [Header("--------- ��� ���� ---------")]
    public GameObject block; // ��� ������
  
    [Header("--------- ��� ���� --------")]
    public int _firstbock; // ó�� ������ ��� ����
    public int _againblock; // �� ���� �߰� ������ ��� ��

    [Header("---------- ��, �찪 -------")]
    public Vector2 left;    
    public Vector2 right;        

    [Header("--------- �÷��̾� -------")]
    public Transform playerTransform; // (���� ���ÿ����� ���� ������ ����)

    [Header("--------- ��ư ���� -------")]
    public Button _upButton; // UpBtn UI ��ư ����
    public Button _turnButton; // Trun ��ư UI ��ư ����
    public int _SpawnBlock; // ��� �߰� ������ Ʈ������ ��ư ���� Ƚ��

    [Header("--------- ���� ---------")]
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject applePrefab;
    



    private Vector2 lastPos; // ������ ���� ��ġ
    private int _numberspawn = 0; // ������� ������ ��� �� (�ʱ� ���� ����)
    private int _totalPresses = 0; // UpBtn �Ǵ� Trun ��ư�� ���� �� Ƚ��

    void Awake()
    {
        // �ν����Ϳ� ������ ���� �߸����� ���� ����� ������ x��ȣ�� ����
        left.x = -Mathf.Abs(left.x);
        right.x = Mathf.Abs(right.x);
    }

    void Start()
    {
        // ���� ��ġ ����
        lastPos = new Vector2(0.58f, -5.96f);

        // ù ��� ���� (�⺻ ��ġ��, z = -1f)
        Vector3 firstPosWithZ = new Vector3(lastPos.x, lastPos.y, -1f);
        Instantiate(block, firstPosWithZ, Quaternion.identity);
        _numberspawn++; // ù ��� ���� �� ī��Ʈ ����

        // ������ �ʱ� ��ܵ� ����
        for (int i = 0; i < _firstbock - 1; i++)
        {
            SpawnNextStair();
        }

        // UI ��ư�� Ŭ�� �̺�Ʈ ������ �߰�
        if (_upButton != null)
        {
            _upButton.onClick.AddListener(OnButtonPressed);
        }
        if (_turnButton != null)
        {
            _turnButton.onClick.AddListener(OnButtonPressed);
        }
    }

    /// <summary>
    /// ��� �ϳ� ����
    /// </summary>
    private void SpawnNextStair()
    {
        // 40% Ȯ���� ����/������ ���� ���� (���ϴ� Ȯ���� ����)
        bool goRight = Random.value > 0.4f;
        Vector2 chosenOffset = goRight ? right : left;

        Vector2 spawnPos = lastPos + chosenOffset;
        Vector3 spawnPosWithZ = new Vector3(spawnPos.x, spawnPos.y, -1f);
        Instantiate(block, spawnPosWithZ, Quaternion.identity);

        lastPos = spawnPos;
        _numberspawn++; // ��� ���� �� ī��Ʈ ����    

        // ���� Ȯ����
        float randomValue = Random.value;
        if(randomValue < 0.1f)
        {
            // ����� ������ ��ġ���� ���� �� ����
            // coin, apple �������� Instantiate�� ���� ����          

            Vector3 itemSpawnPos = spawnPos + new Vector2(0f, 0.6f);

                        
            float itemPick = Random.value;
            GameObject itemToSpawn = itemPick < 0.6f ? coinPrefab : applePrefab;

            GameObject item = Instantiate(      
                itemToSpawn,
                new Vector3(itemSpawnPos.x, itemSpawnPos.y, -1f),
                Quaternion.identity
            );
        }      
        

    }
                

    /// <summary>
    /// UpBtn �Ǵ� Trun ��ư�� ������ �� ȣ��Ǵ� �Լ�
    /// </summary>
    public void OnButtonPressed()
    {
        _totalPresses++;
        Debug.Log($"��ư�� ���Ƚ��ϴ�! �� ���� Ƚ��: {_totalPresses}ȸ");

        // �� ��ư ���� Ƚ���� _SpawnBlock�� ����� ������ _againblock ��ŭ �߰� ��� ����
        if (_totalPresses % _SpawnBlock == 0 && _totalPresses != 0)
        {
            Debug.Log($"��ư {_SpawnBlock}ȸ ���� ����! ��� {_againblock}�� �߰� ����!");
            // �� for ������ ���� �߰��� �ٽ� �κ�
            for (int i = 0; i < _againblock; i++)
            {
                SpawnNextStair(); // _againblock Ƚ����ŭ SpawnNextStair()�� ȣ��
            }
        }   
    }       
}
            
