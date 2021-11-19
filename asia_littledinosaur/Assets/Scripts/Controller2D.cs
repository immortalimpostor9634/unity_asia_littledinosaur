using UnityEngine;

/// <summary>
/// 控制器:2D橫向卷軸版本
/// </summary>
public class Controller2D : MonoBehaviour
{
    #region
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;
    #endregion

    /// <summary>
    /// 剛體元件 Rigibody 2D
    /// </summary>
    private Rigidbody2D rig;

    // 開始事件:取得元件
    private void Start()
    {
        // 剛體欄位 = 取得元件 <2D剛體> ()
        rig = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update 約 60 FPS
    /// 固定更新事件 : 50 FPS (適用處理物理行為)
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }

    #region
    /// <summary>
    /// 1.玩家是否有按移動按鍵 左、右方向鍵 或 A、D
    /// 2.物件移動行為 (API)
    /// </summary>
    private void Move()
    {
        // h值 指定為 輸入.取得軸向(水平軸) - 水平軸代表左右鍵與AD
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵:" + h);
    }
    #endregion
}