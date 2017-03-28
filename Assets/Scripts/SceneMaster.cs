using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneMaster : MonoBehaviour {

	public builder builder;
	public GameObject builderbot;
	public Canvas restart;
	public Vector3 startpos; 

	void Start () {
		restart = restart.GetComponent<Canvas> ();
		restart.enabled = false; 
		startpos = new Vector3 (0f, 0f, 0f);
	}

	void Update(){
		if(builder.Done == true){
			restart.enabled = true;
			if (Input.GetKeyDown (KeyCode.R)){
				GameStart ();
				builder.Done = false;
				builder.counter = 0;
				builder.tileCount = 0;
				builder.tiles.Clear ();
				//Instantiate (builder, startpos, Quaternion.identity);
			}
		}

	}
	public void GameStart(){
		SceneManager.LoadScene ("Week8");
	}
}
