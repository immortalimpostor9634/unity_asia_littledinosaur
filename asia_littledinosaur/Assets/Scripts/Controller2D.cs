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
    public float jump = 500;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳圖層")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion

    /// <summary>
    /// 剛體元件 Rigibody 2D
    /// </summary>
    private Rigidbody2D rig;

    /// <summary>
    /// 繪製圖示
    /// 在Unity繪製輔助用的圖示
    /// 線條、射線、圓形、方形、扇形、圖片
    /// 圖示 Gizmos 類別
    /// </summary>
    private void OnDrawGizmos()
    {
        // 1. 決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        // 2. 決定繪製圖形
        // transform.postion 此物件的世界座標
        // transform.TransformDirection() 根據變形元件的區域座標轉換為世界座標
        Gizmos.DrawSphere(transform.position + transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }

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

    private void Update()
    {
        Flip();
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

        // 剛體元件.加速度 = 新 二維向量(h 值 = 移動速度，剛體.加速度.垂直);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }

    /// <summary>
    /// 翻面:
    /// 左:角度 Y 180
    /// 右:角度 Y 0
    /// </summary>
    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");

        // 如果 h 小於 0 左:角度 Y 180
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        // 如果 h  值 大於 0 右:角度 Y 0
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
    #endregion
}