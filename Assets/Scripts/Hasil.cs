using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Hasil : MonoBehaviour {

	private int idLevel;

	public Text txtHasil;
	public Text txtInfoLevel;

	public GameObject bintang1;
	public GameObject bintang2;
	public GameObject bintang3;

	private int HasilA;
	private int jBenar;


	// Use this for initialization
	void Start () {
		idLevel = PlayerPrefs.GetInt("idLevel");

		bintang1.SetActive(false);
		bintang2.SetActive(false);
		bintang3.SetActive(false);


		HasilA = PlayerPrefs.GetInt("HasilTemp"+idLevel.ToString());
		jBenar = PlayerPrefs.GetInt("jBenarTemp"+idLevel.ToString());

		txtHasil.text = HasilA.ToString();
		txtInfoLevel.text = "Anda menjawab benar "+jBenar.ToString()+" soal";

		if(HasilA == 100)
		{
			bintang1.SetActive(true);
			bintang2.SetActive(true);
			bintang3.SetActive(true);
		}
		else if(HasilA >= 70)
		{
			bintang1.SetActive(true);
			bintang2.SetActive(false);
			bintang3.SetActive(true);
		}
		else if(HasilA >= 50)
		{
			bintang1.SetActive(false);
			bintang2.SetActive(false);
			bintang3.SetActive(true);
		}

	}


	public void mulaiLagi()
	{
		Application.LoadLevel ("M"+idLevel.ToString());
	}

}
