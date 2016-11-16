using UnityEngine;
using System.Collections;

public class GameSceneControl : MonoBehaviour {

    private GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = GameController.instance;
        Debug.Log("GameSceneControl：游戏难度 --> " + gameController.difficulty);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
