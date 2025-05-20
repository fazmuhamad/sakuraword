using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pengenalanHiragana : MonoBehaviour {

	private int idLevel;
	
	public Text huruf;
	public Text Hiragana;



	public Text jawaban2;
	
	public Text infoJawaban;


	
	public string[] hurufHuruf; 		//buat nyimpen soal
	public string[] hiraganaHiragana; 		//buat nyimpen soal



	public string[] alternative2; 	// buat nyimpen pilihan 2
	
	
	private int idSoal;
	
	private float jBenar;
	private float pertanyaan;


	
	// Use this for initialization
	void Start () {
		idLevel = PlayerPrefs.GetInt("idLevel");
		idSoal = 0;
		pertanyaan = hurufHuruf.Length;
		
		
		huruf.text = hurufHuruf[idSoal];
		Hiragana.text = hiraganaHiragana[idSoal];


	
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
			Hiragana.text = hiraganaHiragana[idSoal];




			jawaban2.text = alternative2[idSoal];
			
			
			infoJawaban.text = "Kata "+(idSoal + 1).ToString()+ "/"+pertanyaan.ToString();
		}
		else
		{
			Application.LoadLevel("MenuBagan");
		}
	
	}
}
