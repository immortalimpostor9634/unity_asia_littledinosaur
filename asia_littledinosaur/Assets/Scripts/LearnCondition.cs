
using UnityEngine;

/// <summary>
/// 認識判斷式 (條件式)
/// </summary>

public class LearnCondition : MonoBehaviour
{
    public bool opendoor;
    public int score = 70;
    public string weapon = "刀子";

    // 開始事件 : 播放遊戲會執行一次的事件
    private void Start() { }

    // 更新事件 : 約一秒鐘執行六十次的事件 (60 FPS)
    private void Update()
    {
        print("持續執行~");

        #region 判斷式 if
        // 否則 如果 else if (布林值) {程式內容} 只能至於 if 下方、else下方，且無數量限制
        // 如果 分數 >= 60 及格
        // 如果 分數 >= 60 但是 >= 40 補考
        // 否則 不及格

        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考!");
        }
        else if (score >= 20)
        {
            print("當掉!");
        }
        else
        {
            print("不及格...");
        }
        #endregion

        #region 判斷式 switch
        // 語法 : switch (判斷用的值)
        // {
        // case "刀子" :
        //    攻擊力 10 ;
        //    break ;
        // case "機關槍" :
        //    攻擊力 100 ;
        //    break ;
        // default :
        //    這不是武器 ;
        //    break ;
        // }

        switch (weapon)
        {
            case "刀子":
                print("攻擊力 10");
                break;
            case "機關槍":
                print("攻擊力 100");
                break;
            default:
                print("這不是武器");
                break;
        }
        #endregion
    }
}
