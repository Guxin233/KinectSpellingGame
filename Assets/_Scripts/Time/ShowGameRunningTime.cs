using UnityEngine;
using System.Collections;

/// <summary>
/// 显示游戏已运行的时间于屏幕左上角，主要用于测试
/// </summary>
public class ShowGameRunningTime : MonoBehaviour {

    private float timer = 0f;
    private int h = 0;
    private int m = 0;
    private int s = 0;
    private string timeStr = string.Empty;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            s++;
            timer = 0; // 记录1秒内的时间
        }
        if (s >= 60)
        {
            m++;
            s = 0;
        }
        if (m >= 60)
        {
            h++;
            m = 0;
        }
        if (h >= 99)
        {
            h = 0;
        }
    }

    void OnGUI()
    {
        timeStr = string.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s); // D2表示2位十进制
        GUI.Label(new Rect(10, 10, 100, 200), timeStr);
    }

}
