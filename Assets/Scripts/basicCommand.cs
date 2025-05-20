using UnityEngine;
using System.Collections;

public class basicCommand : MonoBehaviour {

	public void loadScenes(string namaScene)
	{
		Application.LoadLevel(namaScene);
	}

	public void ulangSkor()
	{
	 
		PlayerPrefs.DeleteAll();
	}



}
