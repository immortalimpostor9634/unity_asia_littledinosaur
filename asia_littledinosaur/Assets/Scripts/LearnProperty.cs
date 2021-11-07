
using UnityEngine;

/// <summary>
/// 學習非靜態屬性
/// </summary>
public class LearnProperty : MonoBehaviour
{
    // 非靜態屬性使用方法
    // 1. 定義一個欄位 : 用於儲存實體物件
    // 2. 欄位資料類型必須與想存取的非靜態屬性類別相同
    // 3. 欄位必須存放實體物件 (將物件拖曳至欄位內)
    public Transform traA;
    public Camera CamA;

    private void Start()
    {
        // 取得 Get
        // 欄位名稱.非靜態屬性名稱
        print("A物件的座標:" + traA.position);
        print("A攝影機的深度:" + CamA.depth);
        // 設定 Set
        // 語法 : 欄位名稱.非靜態屬性名稱 指定 值
        CamA.depth = 9.9f;
        traA.position = new Vector2(-7, 3);
    }
}
