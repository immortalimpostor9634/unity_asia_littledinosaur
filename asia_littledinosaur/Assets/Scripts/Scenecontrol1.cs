using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenecontrol1 : MonoBehaviour
{

    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void Quit()
    {
        Application.Quit();  // ���}�{��
        print("�����C��");
    }

}
