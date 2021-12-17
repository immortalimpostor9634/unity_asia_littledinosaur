
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 對話系統
/// 將需要輸出的文字利用打字效果呈現
/// </summary>
public class Dialoguesystem : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
        // StartCoroutine(TypeEffect());
    }

    /// <summary>
    /// 打字效果
    /// </summary>
    /// <param name = "contents">想要出現在對話系統的對話內容，需使用字串陣列</param>
    private IEnumerator TypeEffect(string[] contents)
    {
        // 更換名稱快捷鍵 ctrl+RR
        // 測試用
        // string test1 = "哈囉,你好~";
        // string test2 = "今天的天氣真好~";
        // string[] contents = { test1,test2 };

        goDialogue.SetActive(true);   // 顯示對話物件

        for (int j = 0; j < contents.Length; j++)   // 遍尋所有對話
        {
            textContent.text = "";    // 清除上次對話內容
            goTip.SetActive(false);   // 隱藏三角形圖示

            for (int i = 0; i < contents[j].Length; i++)   // 遍尋對話中的每一個字
            {
                textContent.text += contents[j][i];    // 疊加對話內容文字介面
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);

            while (!Input.GetKeyDown(keyDialogue))
            {
                yield return null;
            }
        }
        goDialogue.SetActive(false);
    }
}
