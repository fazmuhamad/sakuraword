using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class Kategori : MonoBehaviour {

	public GameObject katPrefab;
	public MenuManager menu;
	public Soal soal;


	void Start () {

		RectTransform rect = gameObject.GetComponent<RectTransform> ();

		string filePath = Application.streamingAssetsPath+"/";
		GameObject.Find ("Alamat").GetComponent<Text> ().text = filePath;
		DirectoryInfo dir = new DirectoryInfo (filePath);
		//FileInfo[] files = dir.GetFiles ("*.json");
		//Debug.Log(files.Length);
		//GameObject.Find ("Alamat").GetComponent<Text> ().text = files.Length.ToString();

		TextAsset[] files = Resources.LoadAll<TextAsset> ("");

		foreach(TextAsset file in files){
			Debug.Log (files.Length);
			GameObject kat = Instantiate(katPrefab) as GameObject;
			kat.name = Path.GetFileNameWithoutExtension(file.name).ToString();
			kat.transform.SetParent(GameObject.Find("Kategori/Panel/KotakPanel/Scroll/KategoriC").GetComponent<Transform>(), false);
			kat.GetComponentInChildren<Text>().text = kat.name;
			string katName = kat.name;
			kat.GetComponent<Button>().onClick.AddListener(() => onClick(katName));
			kat.GetComponent<Button>().onClick.AddListener(() => menu.ShowMenu(GameObject.Find("Canvas/Soal").GetComponent<Menu>()));


		}
		rect.sizeDelta = new Vector2 (rect.sizeDelta.x, (rect.sizeDelta.y/2)* files.Length);

	}

	public void onClick(string kategori){
		soal.SoalBegin (kategori);
		Debug.Log (kategori);

	}
}
