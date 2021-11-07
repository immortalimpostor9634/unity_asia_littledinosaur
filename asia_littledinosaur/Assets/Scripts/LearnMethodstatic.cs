
using UnityEngine;

/// <summary>
/// 學習靜態方法
/// </summary>
public class LearnMethodstatic : MonoBehaviour
{
    private void Start()
    {
        // 學習靜態方法
        // 語法 : 類別名稱.靜態方法名稱(對應的引數);
        int rint = Random.Range(1, 3);
        print("隨機整數 1 與 3 :" + rint);

        print("-99的絕對值:" + Mathf.Abs(-99));
    }
}
