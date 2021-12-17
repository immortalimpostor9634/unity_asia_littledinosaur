
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// ��ܨt��
/// �N�ݭn��X����r�Q�Υ��r�ĪG�e�{
/// </summary>
public class Dialoguesystem : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect()
    {
        string test1 = "���o,�A�n~";
        string test2 = "���Ѫ��Ѯ�u�n~";
        string[] test = { test1,test2 };

        textContent.text = "";    // �M���W����ܤ��e
        goDialogue.SetActive(true);   // ��ܹ�ܪ���

        for (int j = 0; j < test.Length; j++) 
        {
            for (int i = 0; i < test[j].Length; i++)
            {
                textContent.text += test[j][i];    // �|�[��ܤ��e��r����
                yield return new WaitForSeconds(interval);
            }
        }
    }
}
