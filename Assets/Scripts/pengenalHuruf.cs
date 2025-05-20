using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pengenalHuruf : MonoBehaviour {

	private int idLevel;
	
	public Text huruf;
	public Text Onyomi;
	public Text Kunyomi;
	public Text Arti;
	public GameObject suara;
	public Text jawaban1;
	public Text jawaban2;

	public Text infoJawaban;
	
	public string[] hurufHuruf; 		//buat nyimpen soal
	public string[] OnyomiOnyomi; 		//buat nyimpen soal
	public string[] KunyomiKunyomi; 		//buat nyimpen soal
	public string[] ArtiArti; 		//buat nyimpen soal
	public AudioClip[] suaraOnyomi;
	public string[] alternative2; 	// buat nyimpen alternatif 2


	private int idSoal;
	
	private float jBenar;
	private float pertanyaan;



	
	// Use this for initialization
	void Start () {
		idLevel = PlayerPrefs.GetInt("idLevel");
		idSoal = 0;
		pertanyaan = hurufHuruf.Length;

		
		huruf.text = hurufHuruf[idSoal];
		Onyomi.text = OnyomiOnyomi[idSoal];
		Kunyomi.text = KunyomiKunyomi[idSoal];
		Arti.text = ArtiArti[idSoal];



		jawaban2.text = alternative2[idSoal];
		
		infoJawaban.text = "Kata "+(idSoal + 1).ToString()+ "/"+pertanyaan.ToString();
		
	}
	
	public void respon(string alternative)
	{

		soalBerikutnya();
	}
	
	
	void soalBerikutnya()
	{
		idSoal += 1;
		
		if(idSoal <= (pertanyaan-1))
		{
			huruf.text = hurufHuruf[idSoal];
			Onyomi.text = OnyomiOnyomi[idSoal];
			Kunyomi.text = KunyomiKunyomi[idSoal];
			Arti.text = ArtiArti[idSoal];



			jawaban2.text = alternative2[idSoal];
			
			
			infoJawaban.text = "Kata "+(idSoal + 1).ToString()+ "/"+pertanyaan.ToString();
		}
		else
		{
			Application.LoadLevel("MenuBagan");
		}
		
		
		
	}
	
	
	
	
}
