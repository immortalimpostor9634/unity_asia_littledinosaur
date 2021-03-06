
using UnityEngine;
using System.Collections;   //引用 系統.集合 包含協同程序

/// <summary>
/// 認識協同程序
/// </summary>
public class Learncoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());
        StartCoroutine(TestWithLoop());
    }

    // 定義協同程序
    // 傳回類型 IEnumerator
    private IEnumerator Test() 
    {
        print("第一段文字");
        yield return new WaitForSeconds(1);  // 等待秒數
        print("第二段文字");
        yield return new WaitForSeconds(3);
        print("第三段文字");

    }
    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i<10; i++)
        {
            print("數字:" + i);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
