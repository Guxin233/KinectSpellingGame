using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public int curSceneIndex;   // 当前场景。0：开始场景。1：游戏场景。2：结束场景。
    public int difficulty;      // 游戏难度。0：初级。1：中级。2：高级。

    void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        curSceneIndex = 0;  
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   
}
