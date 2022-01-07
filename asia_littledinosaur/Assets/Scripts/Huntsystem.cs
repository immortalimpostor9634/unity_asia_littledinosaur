using UnityEngine;
using UnityEngine.UI;

public class Huntsystem : MonoBehaviour
{

    [Header("血條")]
    public Image imgHPbar;
    [Header("血量")]
    public float HP = 100;
    [Header("動畫參數")]
    public string parameterDead = "觸發死亡";

    private float HPmax;
    private Animator ani;

    // 喚醒事件 : 在 Start 之前執行一次
    private void Awake()
    {
        HPmax = HP;
        ani = GetComponent<Animator>();
    }

    /// <summary>
    /// 受傷
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
