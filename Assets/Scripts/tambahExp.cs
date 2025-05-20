using UnityEngine;
using System.Collections;

public class tambahExp : MonoBehaviour {

	private int curLevel = 1;
	private int maxLevel;

	private int curExp = 1;
	private int maxExp = 100;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(curExp >= maxExp)
		{
			curExp = 1;
			curLevel++;
		}
	}
	void onGUI()
	{
		GUI.Box(new Rect(20, 50, 200, 20), curExp + " / " + maxExp);
		GUI.Box(new Rect(20, 50, 200, 20), "Level: " + curLevel);
	}
}
