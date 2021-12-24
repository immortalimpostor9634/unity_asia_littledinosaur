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
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�p���s";

    // Ĳ�o�}�l�ƥ�
    // 1. ��Ӫ��󳣭n�� Collider2D
    // 2. ��Ӫ���n���@�Ӧ� Rigidbody2D
    // 3. ��Ӫ���n���@�Ӥ� Is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            Dialoguesystem.StartDialogue(datadialogue.dialogues);
        }
        print("���F��i�JĲ�o�ϰ�F");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
            if (collision.name == target)
            {
                Dialoguesystem.StopDialogue();
            }
        
    }
}
