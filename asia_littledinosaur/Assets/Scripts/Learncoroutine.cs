
using UnityEngine;
using System.Collections;   //�ޥ� �t��.���X �]�t��P�{��

/// <summary>
/// �{�Ѩ�P�{��
/// </summary>
public class Learncoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());
    }

    // �w�q��P�{��
    // �Ǧ^���� IEnumerator
    private IEnumerator Test() 
    {
        print("�Ĥ@�q��r");
        yield return new WaitForSeconds(1);  // ���ݬ��
        print("�ĤG�q��r");
        yield return new WaitForSeconds(3);
        print("�ĤT�q��r");

    }
}
