
using UnityEngine;

/// <summary>
/// �ǲ߰}�C
/// </summary>
public class LearnArray : MonoBehaviour
{
    #region
    // �T�ӹD�㪺���� : 100 200 300
    public int priceA = 100;
    public int priceB = 200;
    public int priceC = 300;

    // �}�C�S�� : �x�s�ۦP�������
    // �y�k : �׹��� �������[] �}�C�W�� ���w ��;
    public int[] pricese;

    // �}�C��l��
    // �Ĥ@��:���w�}�C�ƶq
    public int[] score = new int[5];
    // �ĤG��:���w�}�C��
    public string[] props = { "����", "�Ť�", "����" };

    public int[] levels = new int[10];

    private void Start()
    {
        // ���o�}�C��� Get
        // �y�k : �}�C�W�� [ �s�� ] - �s���O�q 0 �}�l
        print("�ĤT���D��:" + props[2]);

        // �]�w�}�C��� Get
        // �y�k : �}�C�W�� [ �s�� ] ���w ��;
        props[1] = "�_��";
        print("�ĤG���D��:" + props[1]);

        // �}�C���ƶq
        print("���Ű}�C���ƶq" + levels.Length);

        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = (i + 1);
        }
    }
    #endregion
}
