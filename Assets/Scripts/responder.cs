using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class responder : MonoBehaviour {

	private int idLevel;

	public Text soal;
	public Text jawaban1;
	public Text jawaban2;
	public Text jawaban3;
	public Text jawaban4;
	public Text infoJawaban;

	public string[] soalSoal; 		//buat nyimpen soal
	public string[] alternative1; 	//buat nyimpen alternatif 1
	public string[] alternative2; 	// buat nyimpen alternatif 2
	public string[] alternative3; 	// buat nyimpen alternatif 3
	public string[] alternative4; 	// buat nyimpen alternatif 4
	public string[] koreksi;		// buat nyimpen koreksi

	private int idSoal;

	private float jBenar;
	private float pertanyaan;
	private float media;
	private int Hasil;

	// Use this for initialization
	void Start () {
		idLevel = PlayerPrefs.GetInt("idLevel");
		idSoal = 0;
		pertanyaan = soalSoal.Length;

		soal.text = soalSoal[idSoal];
		jawaban1.text = alternative1[idSoal];
		jawaban2.text = alternative2[idSoal];
		jawaban3.text = alternative3[idSoal];
		jawaban4.text = alternative4[idSoal];

		infoJawaban.text = "Kata "+(idSoal + 1).ToString()+ "/"+pertanyaan.ToString();

	}
	
	public void respon(string alternative)
	{
		if(alternative == "1")
		{
			if(alternative1[idSoal] == koreksi[idSoal])
			{
				jBenar += 1;
			}
			//eksekusi jawaban 1
		}

		else if(alternative == "2")
		{
			if(alternative2[idSoal] == koreksi[idSoal])
			{
				jBenar += 1;
			}
			//eksekusi jawaban 2
		}
		else if(alternative == "3")
		{
			if(alternative3[idSoal] == koreksi[idSoal])
			{
				jBenar += 1;
			}
			//eksekusi jawaban 3
		}
		else if(alternative == "4")
		{
			if(alternative4[idSoal] == koreksi[idSoal])
			{
				jBenar += 1;
			}
			//eksekusi jawaban 4
		}

		soalBerikutnya();
	}


	void soalBerikutnya()
	{
		idSoal += 1;

		if(idSoal <= (pertanyaan-1))
		{
		soal.text = soalSoal[idSoal];
		jawaban1.text = alternative1[idSoal];
		jawaban2.text = alternative2[idSoal];
		jawaban3.text = alternative3[idSoal];
		jawaban4.text = alternative4[idSoal];
		
		infoJawaban.text = "Kata "+(idSoal + 1).ToString()+ "/"+pertanyaan.ToString();
		}
		else
		{

			media = 100 *(jBenar / pertanyaan); //menghitung berdasarkan jawaban benar
			Hasil = Mathf.RoundToInt(media); //menghitung seluruh dengan aturan matematik

			if(Hasil > PlayerPrefs.GetInt("Hasil"+idLevel.ToString()))

			{
				PlayerPrefs.SetInt("Hasil"+idLevel.ToString(), Hasil);
				PlayerPrefs.SetInt("jBenar"+idLevel.ToString(), (int) jBenar);
			}

			PlayerPrefs.SetInt("HasilTemp"+idLevel.ToString(), Hasil);
			PlayerPrefs.SetInt("jBenarTemp"+idLevel.ToString(), (int) jBenar);

			Application.LoadLevel("Hasil");
		}
	


	}




}
