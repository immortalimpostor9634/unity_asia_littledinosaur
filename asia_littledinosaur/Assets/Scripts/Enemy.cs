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

    private Rigidbody2D rig;

    #endregion

    #region �ƥ�

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void OnDrawGizmos()
    {
        // ���w�ϥܪ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        // ø�s�ߤ���(����,�ؤo)
        Gizmos.DrawCube(transform.position + 
            transform.TransformDirection(v3Trackoffset), v3TrackSize);
    }
    private void Update()
    {
        CheckTargetInArea();
    }

    #endregion

    #region  ��k

    /// <summary>
    /// �ˬd�ؼЬO�_�b�ϰ줺
    /// </summary>
    private void CheckTargetInArea()
    {
        // 2D���z.�л\����(����,�ؤo,����)
        Collider2D hit = Physics2D.OverlapBox(transform.position +
            transform.TransformDirection(v3Trackoffset), v3TrackSize, 0, layerTarget);

        if (hit) rig.velocity = new Vector2(-speed, rig.velocity.y);
    }

    #endregion
}
