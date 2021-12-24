using UnityEngine;

/// <summary>
/// NPC行為
/// 偵測目標進入碰撞區
/// 顯示對話系統
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public Datadialogue datadialogue;
    [Header("對話系統")]
    public Dialoguesystem Dialoguesystem;

    // 觸發開始事件
    // 1. 兩個物件都要有 Collider2D
    // 2. 兩個物件要有一個有 Rigidbody2D
    // 3. 兩個物件要有一個勾 Is Trigger

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("有東西進入觸發區域了");
    }
}
