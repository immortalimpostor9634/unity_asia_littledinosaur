using UnityEngine;

public class Enemy : MonoBehaviour
{

    #region  ���
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3Trackoffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    #endregion

    #region �ƥ�
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + v3Trackoffset, v3TrackSize);
    }
    #endregion

    #region  ��k

    #endregion
}
