using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// 计时器。显示游戏剩余时间。
/// </summary>
public class ShowRemainGameTime : MonoBehaviour {

    public Text timeText;         // 显示剩余游戏时间的控件
    public int remainTime = 60;   // 默认一局60秒

    private bool showHourMinuteSecond;   // 00:00:00
    private bool showMinuteSecond;       // 00:00


    void Start()
    {
        InvokeRepeating("RefreshTime", 0, 1f);
    }

    /// <summary>
    /// 每秒刷新一次剩余游戏时间
    /// </summary>
    void RefreshTime()
    {
        if (remainTime > 0)
        {
            remainTime -= 1; // -1s
            timeText.text = "剩余时间：" + remainTime;
        }
        else
        {
            // 游戏时间结束

        }
    }

}
