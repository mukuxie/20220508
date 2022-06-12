using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLoginTime : MonoBehaviour
{
    public Button logintieBtn;

    //進入限時模式
    private void Awake()
    {
        logintieBtn.onClick.AddListener(() =>
        {
            // 登录按钮被点击，进入Game场景
            SceneManager.LoadScene(3);
        });
    }
}