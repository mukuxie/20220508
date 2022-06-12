using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    //從限時模式反回遊戲選單
    public Button BackMenu;

    private void Awake()
    {
        BackMenu.onClick.AddListener(() =>
        {
            // 登录按钮被点击，进入Game场景
            SceneManager.LoadScene(1);
        });
    }
}
