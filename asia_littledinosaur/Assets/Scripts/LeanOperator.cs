using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1. ���w =
/// 2. �ƾ� + - * / % ++(���W) --(����) += -= *= /= %=
/// 3. ��� > < >= <= ==(���P��) !=(������)  (����@�ߩ�k��A�ݨϥΥb�βŸ�)
/// 4. �޿� &&(�åB) ||(�Ϊ�) !(�A��)
/// </summary>
public class LeanOperator : MonoBehaviour
{
    #region ���w�B��l
    // ���w�B��l�S��
    // �� ���w�B��l�S�ʥ�����k��A���w������
    public int number = 10;     // ���w : �N�Ʀr 10 ���w����� number

    public float numberA = 10;
    public float numberB = 3;
    public float numberC = 30;
    public float numberD = 5;

    public float numberE = 9;
    public float numberF = 1;
    #endregion

    public bool boolA = true;
    public bool boolB = false;

    private void Start()
    {

        #region �ƾǹB��l
        print("�[�k:" + (numberA + numberB));
        print("��k:" + (numberA - numberB));
        print("���k:" + (numberA * numberB));
        print("���k:" + (numberA / numberB));
        print("�l��:" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC �� 1 : " + numberC);
        numberC--;                           // ���� 
        print("numberC �� 1 : " + numberC);

        numberD = numberD + 10;
        print("numberD �[ 1 : " + numberD);
        numberD += 10;                       // ���W���w + - * / %
        print("numberD �[ 1 : " + numberD);

        #endregion

        #region ����B��l
        // �@�� : �����ӭȡA�è��o���L�ȵ��G
        print("E > F : " + (numberE > numberF));    //t
        print("E < F : " + (numberE < numberF));    //f
        print("E >= F : " + (numberE >= numberF));  //t
        print("E <= F : " + (numberE <= numberF));  //f
        print("E == F : " + (numberE == numberF));  //f
        print("E != F : " + (numberE != numberF));  //t
        #endregion

        #region
        // �@�� : �����ӥ��L�ȡA�è��o���L�ȵ��G
        // &&(�åB) : �u�n���@�� false �A���G�N�� false 
        print("T && T :" + (true && true));         //t
        print("T && F :" + (true && false));        //f
        print("F && T :" + (false && true));        //f
        print("F && F :" + (false && false));       //f
        // ||(�Ϊ�) : �u�n���@�� true �A���G�N�� true 
        print("T || T :" + (true || true));         //t
        print("T || F :" + (true || false));        //t
        print("F || T :" + (false || true));        //t
        print("F || F :" + (false || false));       //f
        // !(�A��) : �N���L���ܬ��ۤ�
        print("!true : " + (!true));                //f
        print("!false : " + (!false));              //t
        #endregion
    }

}
