using UnityEngine;
using System.Collections;

public class levelInfo : MonoBehaviour {

	public int idlevel;

	public GameObject bintang1;
	public GameObject bintang2;
	public GameObject bintang3;

	private int 	hasil;

	// Use this for initialization
	void Start () {
		bintang1.SetActive(false);
		bintang2.SetActive(false);
		bintang3.SetActive(false);

		int Hasil = PlayerPrefs.GetInt("HasilTemp"+idlevel.ToString());

		
		if(Hasil == 10)
		{
			bintang1.SetActive(true);
			bintang2.SetActive(true);
			bintang3.SetActive(true);
		}
		else if(Hasil >= 7)
		{
			bintang1.SetActive(true);
			bintang2.SetActive(true);
			bintang3.SetActive(false);
		}
		else if(Hasil >= 5)
		{
			bintang1.SetActive(true);
			bintang2.SetActive(false);
			bintang3.SetActive(false);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
