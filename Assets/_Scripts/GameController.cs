using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController instance;
    private int curSceneIndex;  // 当前场景。0：开始场景。1：游戏场景。2：结束场景。

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
