
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
        StartCoroutine(TestWithLoop());
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
    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i<10; i++)
        {
            print("�Ʀr:" + i);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
