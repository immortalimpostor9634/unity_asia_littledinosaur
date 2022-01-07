using UnityEngine;
using UnityEngine.UI;

public class Huntsystem : MonoBehaviour
{

    [Header("���")]
    public Image imgHPbar;
    [Header("��q")]
    public float HP = 100;
    [Header("�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";

    private float HPmax;
    private Animator ani;

    // ����ƥ� : �b Start ���e����@��
    private void Awake()
    {
        HPmax = HP;
        ani = GetComponent<Animator>();
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage"></param>
    public void Hunt(float damage)
    {
        HP -= damage;
        imgHPbar.fillAmount = HP / HPmax;
        if (HP <= 0) Dead();
    }

    private void Dead()
    {
        ani.SetTrigger(parameterDead);
    }

}
