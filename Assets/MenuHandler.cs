using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] string gameScene;
    [SerializeField] string startMenu;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameScene);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(startMenu);
    }
}
