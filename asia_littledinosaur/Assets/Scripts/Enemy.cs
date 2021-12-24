using UnityEngine;

public class Enemy : MonoBehaviour
{

    #region  欄位
    [Header("檢查追蹤區域大小與位移")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3Trackoffset;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
    public LayerMask layerTarget;
    #endregion

    #region 事件
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + v3Trackoffset, v3TrackSize);
    }
    #endregion

    #region  方法

    #endregion
}
