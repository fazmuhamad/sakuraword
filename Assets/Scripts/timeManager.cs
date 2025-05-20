using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeManager : MonoBehaviour {

	public float waktuAwal;
	private Text tulisan;

	
	// Use this for initialization
	void Start () {
	
		tulisan = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
	
		waktuAwal -= Time.deltaTime;
		if(waktuAwal <= 0)
		{
			Application.LoadLevel ("Gagal");

		}

		tulisan.text = "" + Mathf.Round (waktuAwal);

	}
}
