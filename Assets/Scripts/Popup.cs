using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour {

	public GameObject popPanel;
	// Use this for initialization
	void Start () {
		popPanel.SetActive(false);
	}

	public void close()
	{	popPanel.SetActive(false);

	}

	public void open()
	{	popPanel.SetActive(true);

	}
	public void keluar()
	{
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
