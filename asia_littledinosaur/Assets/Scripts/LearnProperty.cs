
using UnityEngine;

/// <summary>
/// �ǲ߫D�R�A�ݩ�
/// </summary>
public class LearnProperty : MonoBehaviour
{
    // �D�R�A�ݩʨϥΤ�k
    // 1. �w�q�@����� : �Ω��x�s���骫��
    // 2. ��������������P�Q�s�����D�R�A�ݩ����O�ۦP
    // 3. ��쥲���s����骫�� (�N����즲����줺)
    public Transform traA;
    public Camera CamA;

    private void Start()
    {
        // ���o Get
        // ���W��.�D�R�A�ݩʦW��
        print("A���󪺮y��:" + traA.position);
        print("A��v�����`��:" + CamA.depth);
        // �]�w Set
        // �y�k : ���W��.�D�R�A�ݩʦW�� ���w ��
        CamA.depth = 9.9f;
        traA.position = new Vector2(-7, 3);
    }
}
