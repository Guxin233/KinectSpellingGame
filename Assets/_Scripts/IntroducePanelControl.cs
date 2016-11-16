using UnityEngine;
using System.Collections;

public class IntroducePanelControl : MonoBehaviour {

    public GameObject pageGroup;

    private Canvas canvas;
    private int pageCount;      // 一共有多少个分页
    private int curPageIndex;   // 当前的页码

    // Use this for initialization
    void Start () {
        pageCount = pageGroup.transform.childCount;
        curPageIndex = 0;           // 默认显示第一页
        PageTurn(curPageIndex);     
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// 翻页到指定的页码
    /// </summary>
    /// <param name="pageIndex"></param>
    void PageTurn(int pageIndex)
    {
        // 获得pageGroup里所有页面
        for (int i = 0; i < pageCount; i++)
        {
            Transform page = pageGroup.transform.GetChild(i);
            if (i == pageIndex)
            {
                page.gameObject.SetActive(true);
            }
            else
            {
                page.gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// 点击上一页按钮，返回上一页
    /// </summary>
    public void ClickPreviousPageBtn()
    {
        curPageIndex--;
        if (curPageIndex < 0)
        {
            curPageIndex = 0;
        }
        PageTurn(curPageIndex);
    }

    /// <summary>
    /// 点击返回主菜单按钮
    /// </summary>
    public void ClickBackBtn()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// 点击下一页按钮，翻到下一页
    /// </summary>
    public void ClickNextPageBtn()
    {
        curPageIndex++;
        if (curPageIndex > pageCount - 1)
        {
            curPageIndex = pageCount - 1;
        }
        PageTurn(curPageIndex);
    }

    /// <summary>
    /// 传入画布
    /// </summary>
    /// <param name="canvas"></param>
    public void InitIntroducePanel(Canvas canvas)
    {
        this.canvas = canvas;
    }

}
