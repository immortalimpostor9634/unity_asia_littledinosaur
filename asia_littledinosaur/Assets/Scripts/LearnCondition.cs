
using UnityEngine;

/// <summary>
/// �{�ѧP�_�� (����)
/// </summary>

public class LearnCondition : MonoBehaviour
{
    public bool opendoor;
    public int score = 70;
    public string weapon = "�M�l";

    // �}�l�ƥ� : ����C���|����@�����ƥ�
    private void Start() { }

    // ��s�ƥ� : ���@�������椻�Q�����ƥ� (60 FPS)
    private void Update()
    {
        print("�������~");

        #region �P�_�� if
        // �_�h �p�G else if (���L��) {�{�����e} �u��ܩ� if �U��Belse�U��A�B�L�ƶq����
        // �p�G ���� >= 60 �ή�
        // �p�G ���� >= 60 ���O >= 40 �ɦ�
        // �_�h ���ή�

        if (score >= 60)
        {
            print("�ή�~");
        }
        else if (score >= 40)
        {
            print("�ɦ�!");
        }
        else if (score >= 20)
        {
            print("��!");
        }
        else
        {
            print("���ή�...");
        }
        #endregion

        #region �P�_�� switch
        // �y�k : switch (�P�_�Ϊ���)
        // {
        // case "�M�l" :
        //    �����O 10 ;
        //    break ;
        // case "�����j" :
        //    �����O 100 ;
        //    break ;
        // default :
        //    �o���O�Z�� ;
        //    break ;
        // }

        switch (weapon)
        {
            case "�M�l":
                print("�����O 10");
                break;
            case "�����j":
                print("�����O 100");
                break;
            default:
                print("�o���O�Z��");
                break;
        }
        #endregion
    }
}
