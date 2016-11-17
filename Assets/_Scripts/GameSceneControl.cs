using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSceneControl : MonoBehaviour {

    public Text pauseBtnText;   // 暂停按钮上的文字
    public Image curtainImage;  // 变暗的幕布

    private GameController gameController;
    private bool isGamePause;   // 游戏是否已暂停

    // Use this for initialization
    void Start () {
        gameController = GameController.instance;
        Debug.Log("GameSceneControl：游戏难度 --> " + gameController.difficulty);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// 暂停/继续游戏
    /// </summary>
    public void GamePause()
    {
        if (isGamePause)
        {
            // 继续游戏
            isGamePause = false;
            Time.timeScale = 1;
            pauseBtnText.text = "暂停";
            curtainImage.gameObject.SetActive(false);
        }
        else
        {
            // 暂停游戏
            isGamePause = true;
            Time.timeScale = 0;
            pauseBtnText.text = "继续";
            curtainImage.gameObject.SetActive(true);
        }
    }

}
