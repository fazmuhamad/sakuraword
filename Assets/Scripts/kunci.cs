using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class kunci : MonoBehaviour {

	public Button btnUnlock;
	public Button btnKunci;
	public int			nomerSoal;
	
	private int			idLevel;


	public void selectLevel(int i)
	{
		idLevel = i;
		PlayerPrefs.SetInt("idLevel", idLevel);

		
		int Hasil = PlayerPrefs.GetInt("HasilTemp"+idLevel.ToString());
		int jBenar = PlayerPrefs.GetInt("jBenar"+idLevel.ToString());
		

		
		if(jBenar == 10)
		{
			btnUnlock.interactable = true;
			
			
		}
		else if(jBenar >= 7)
		{

			btnUnlock.interactable = true;
			
		}
		else if(jBenar >= 5)
		{

		}

	
	}

	void Update () {
	
	}
}
