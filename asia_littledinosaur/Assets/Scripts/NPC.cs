using UnityEngine;

/// <summary>
/// NPC�欰
/// �����ؼжi�J�I����
/// ��ܹ�ܨt��
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public Datadialogue datadialogue;
    [Header("��ܨt��")]
    public Dialoguesystem Dialoguesystem;

    // Ĳ�o�}�l�ƥ�
    // 1. ��Ӫ��󳣭n�� Collider2D
    // 2. ��Ӫ���n���@�Ӧ� Rigidbody2D
    // 3. ��Ӫ���n���@�Ӥ� Is Trigger

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("���F��i�JĲ�o�ϰ�F");
    }
}
