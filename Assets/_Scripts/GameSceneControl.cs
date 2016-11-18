using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSceneControl : MonoBehaviour {

    public Text pauseBtnText;       // 暂停按钮上的文字
    public Image curtainImage;      // 变暗的幕布
    public Text reaminTimeText;     // 剩余时间的文字
    public Image hpBar;             // 生命条
    public Image timeBar;           // 剩余时间条
    public int startRemainTime = 60;   // 游戏开始时的剩余时间，默认每局60s

    private GameController gameController;
    private bool isGamePause;       // 游戏是否已暂停
    private int remainTime = 60;    // 游戏剩余时间

    // Use this for initialization
    void Start () {
        gameController = GameController.instance;
        Debug.Log("GameSceneControl：游戏难度 --> " + gameController.difficulty);
        InvokeRepeating("Countdown", 0f, 1f);
        InitGame();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// 初始化游戏场景
    /// </summary>
    void InitGame()
    {
        hpBar.fillAmount = 1;
        timeBar.fillAmount = 1;
    }

    /// <summary>
    /// 倒计时
    /// </summary>
    void Countdown()
    {
        remainTime--;
        if (remainTime > 0)
        {
            // 刷新剩余时间
            reaminTimeText.text = remainTime + "s";
            timeBar.fillAmount = remainTime / startRemainTime;
        }
        else
        {
            // 游戏结束
            reaminTimeText.text = "0s";
            // todo
        }
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
