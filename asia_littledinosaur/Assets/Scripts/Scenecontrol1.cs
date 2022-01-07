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
        Application.Quit();  // 離開程式
        print("關閉遊戲");
    }

}
