using UnityEngine;

public class Enemy : MonoBehaviour
{

    #region  ���

    [Header("�ˬd�ϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3Trackoffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterWalk = "�����}��";
    public string parameterAttack = "�����}��";
    [Header("���V�ؼЪ���")]
    public Transform target;
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.3f;
    [Header("�����N�o�ɶ�"), Range(0, 10)]
    public float attackCD = 2.8f;
    [Header("�ˬd�ϰ�j�p�P�첾")]
    public Vector3 v3attackSize = Vector3.one;
    public Vector3 v3attackoffset;
    [Header("�����O"), Range(0, 100)]
    public float attack = 35;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;

    #endregion

    #region �ƥ�

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void OnDrawGizmos()
    {
        // ���w�ϥܪ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        // ø�s�ߤ���(����,�ؤo)
        Gizmos.DrawCube(transform.position + 
            transform.TransformDirection(v3Trackoffset), v3TrackSize);

        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position +
            transform.TransformDirection(v3attackoffset), v3attackSize);

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

        if (hit) Move();
            
            //rig.velocity = new Vector2(-speed, rig.velocity.y);
    }


    private void Move()
    {
        if (target.position.x > transform.position.x)
        {
            // �k�� angle = 180
        }
        else if(target.position.x < transform.position.x)
        {
            // ���� angle = 0
        }

        // �T���B��l�y�k : ���L�� ? ���L�� �� true : ���L�� �� false ;
        angle = target.position.x > transform.position.x ? 0 : 180;

        // �ܧ�.�کԨ��� = Y * ����
        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        // �Z�� = �T���V�q.�Z��(A�I,B�I)
        float distance = Vector3.Distance(target.position, transform.position);
        // print("�P�ؼЪ��Z��:" + distance);

        if (distance <= attackDistance)   // �p�G �Z�� �p�󵥩� �����Z��
        {
            rig.velocity = Vector3.zero;    // ����
            Attack();
        }
    }

    private void Attack()
    {
        if (timerAttack < attackCD)   // �p�G �p�ɾ� �p�� �N�o�ɶ�
        {
            timerAttack += Time.deltaTime;   // �ɶ��֥[ Time.deltaTime �@�V���ɶ�
        }
        else
        {
            ani.SetTrigger(parameterAttack);   // �p�G �p�ɾ� �j�󵥩� �N�o�ɶ� �N����
            timerAttack = 0;     // �p�ɾ� �k�s

            Collider2D hit = Physics2D.OverlapBox(transform.position +
            transform.TransformDirection(v3attackoffset), v3attackSize,0,layerTarget);
            print("�����쪫��:" + hit.name);

            hit.GetComponent<Huntsystem>().Hunt(attack);
        }
    }

    #endregion
}
