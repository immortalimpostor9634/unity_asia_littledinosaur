
using UnityEngine;

/// <summary>
/// �ǲ��R�A�ݩ� static Property
/// </summary>

public class LearnPropertystatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ�
        // ���o Get
        // �y�k : ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);

        print("�Ҧ���v���ƶq:" + Camera.allCamerasCount);
        // �]�w Set - ����� Read Only �ݩʳ]�w
        // �y�k : ���O�W��.�R�A�ݩʦW�� ���w ��
        Time.timeScale = 0.5f;
        Cursor.visible = false;
    }
}
