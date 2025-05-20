using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameLevel : MonoBehaviour {

	public Button 		btnPlay;
	public Text 		txtPilihLevel;


	public GameObject 	infoLevel;
	public Text 		txtInfoLevel;
	public GameObject 	bintang1;
	public GameObject 	bintang2;
	public GameObject 	bintang3;

	public string[]		namaLevel;
	public int			nomerSoal;

	private int			idLevel;


	// Use this for initialization
	void Start () {

		idLevel = 0;
		txtPilihLevel.text = namaLevel[idLevel];
		txtInfoLevel.text = "Benar X dari X soal";
		infoLevel.SetActive(false);
		bintang1.SetActive (false);
		bintang2.SetActive (false);
		bintang3.SetActive (false);
		btnPlay.interactable = false;

	}

	public void selectLevel(int i)
	{
	idLevel = i;
	PlayerPrefs.SetInt("idLevel", idLevel);
	txtPilihLevel.text = namaLevel[idLevel];

		int Hasil = PlayerPrefs.GetInt("HasilTemp"+idLevel.ToString());
		int jBenar = PlayerPrefs.GetInt("jBenar"+idLevel.ToString());

		bintang1.SetActive (false);
		bintang2.SetActive (false);
		bintang3.SetActive (false);

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
			bintang1.SetActive(false);
			bintang2.SetActive(true);
			bintang3.SetActive(false);
		}


	txtInfoLevel.text = "Benar "+jBenar.ToString()+" dari "+nomerSoal.ToString()+" soal";
	infoLevel.SetActive(true);
	btnPlay.interactable = true;
	}

	public void mulai()
	{
		Application.LoadLevel ("M"+idLevel.ToString());
	}



}