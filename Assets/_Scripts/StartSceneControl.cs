using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 开始界面的按钮事件
/// </summary>
public class StartSceneControl : MonoBehaviour {

    public Canvas canvas;
    public GameObject introducePanel;  // 游戏介绍的弹窗
    public GameObject baseBtnGroup;    // 游戏介绍、开始游戏、退出游戏
    public GameObject difficultyChioseBtnGroup; // 初级、中级、高级

    private GameObject curIntroducePanel; // 当前新建的介绍弹窗

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// 按钮事件：弹出游戏介绍弹窗
    /// </summary>
    public void ClickIntroduceBtn() {
        Debug.Log("StartSceneControl：游戏介绍");
        if (curIntroducePanel)
        {
            Destroy(curIntroducePanel);
        }

        // 实例化介绍弹窗
        curIntroducePanel = Instantiate(introducePanel) as GameObject;
        // 画布传入到开始界面
        curIntroducePanel.GetComponent<IntroducePanelControl>().InitIntroducePanel(canvas);
        // 挂到Canvas之下
        curIntroducePanel.transform.SetParent(canvas.transform);
        // 调整位置和大小
        curIntroducePanel.transform.localPosition = Vector3.zero;
        curIntroducePanel.transform.localScale = Vector3.one;
    
    }

    /// <summary>
    /// 按钮事件：选择难度
    /// </summary>
    public void ClickStartBtn()
    {
        Debug.Log("StartSceneControl：选择难度");
        baseBtnGroup.SetActive(false);
        difficultyChioseBtnGroup.SetActive(true);
    }

    /// <summary>
    /// 按钮事件：退出游戏
    /// </summary>
    public void ClickExitBtn()
    {
        Debug.Log("StartSceneControl：退出游戏");
    }

    /// <summary>
    /// 进入游戏场景
    /// </summary>
    /// <param name="difficultyIndex">所选的难度</param>
    public void EnterGameScene(int difficultyIndex)
    {

    }
}
