using UnityEngine;  //�ޥ�Unity�����R�W�Ŷ�:�i�H�ϥΦ��Ŷ���API
//������
//class ���O:�@�Ӫ����Ź�
//�y�k:���O ���O�W�� { ���O���e (���O����) }
//�����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
//�A���ҬO����X�{ {} [ ] () <>
public class Car : MonoBehaviour
{
    #region ���y�k�Υ|�j�`������
    // ��� Field : �O�s�U�����������
    // �y�k : �׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // * �|�j�`������ : 
    //   ��  �� : �x�s�S���p���I�����t��� - int
    //   �B�I�� : �x�s�a���p���I�����t��� - float
    //   �r  �� : �x�s��r��T            - string
    //   ���L�� : �O�P�_ true or false    - bool
    //   * �׹��� :
    //     �p�H : ��L���O����s���B����� private
    //     ���} : ��L���O�i�H�s���B��  �� public
    //   ����ݩ� Attritube
    //   �y�k : [�ݩʦW��(��)]
    //   1. ���D Header (�r��)
    //   2. ���� Tooltip (�r��)
    //   3. �d�� Range (�̤p�ȡB�̤j��) - �ȾA�μƭ�����(int�Bfloat)
    [Header("cc ��"), Range(500,5000)]
    public int cc = 1000;
    [Header("���q"), Range(1,10)]
    public float weight = 3.5f;
    [Header("�~�P�W��"), Tooltip("�o�O���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool hasSkywindow = true;
    #endregion

    #region Unity ���������
    // �C��B�V�q (�y��)�B����B�C������B����
    // �C�� Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1,0.5f);
    // �V�q 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // ���� Keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    // �C������ GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // ���� Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region �ƥ� : �{�����J�f
    // �}�l�ƥ� : �C���}�l�ɰ���@��
    private void Start()
    {
        // �I�s��k : ��k�W��();
        Test();
        Drive80();
        Drive100();
        Drive(120);       // �I�s�ɶ�J���٬� : �޼�
        Drive(990);
        float w99 = ConvertWeight(9.9f);
        print("9.9 �ഫ:" + w99);

        print ("���q�ഫ:" + ConvertWeight(weight));
    }
    #endregion

    #region ��k�y�k
    // ��k : �O�s�{�����e���϶��B�t��k�B���z��
    // �y�k : �׹��� �Ǧ^���� ��k�W�� (�Ѽ�1�B�Ѽ�2...�B�Ѽ�N) { �{������ }
    // void �L�Ǧ^ : �ϥΤ�k�ɤ��|���Ǧ^���
    // �ۭq��k : ���|����B�����I�s�~�|����
    private void Test()
    {
        // ��X(�T��) - �N�T����X�� Unity ����O Console
        print("���o�O�U�w :D");
    }

    private void Drive80()
    {
        print("�}���ɳt:" + 80);
        print("���� : ������");
    }
    private void Drive100()
    {
        print("�}���ɳt:" + 100);
        print("���� : ������");
    }

    // �Ѽƻy�k : ������� �ѼƦW��
    private void Drive(int speed) 
    {
        print("�}���ɳt:" + speed);
        print("���� : ������");
    }

    private float ConvertWeight(float setWeight) 
    {
        return setWeight * 50;
    }
    #endregion
}
