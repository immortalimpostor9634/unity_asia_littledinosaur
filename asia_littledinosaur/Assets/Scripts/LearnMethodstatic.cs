
using UnityEngine;

/// <summary>
/// �ǲ��R�A��k
/// </summary>
public class LearnMethodstatic : MonoBehaviour
{
    private void Start()
    {
        // �ǲ��R�A��k
        // �y�k : ���O�W��.�R�A��k�W��(�������޼�);
        int rint = Random.Range(1, 3);
        print("�H����� 1 �P 3 :" + rint);

        print("-99�������:" + Mathf.Abs(-99));
    }
}
