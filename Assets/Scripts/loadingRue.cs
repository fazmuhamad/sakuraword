using UnityEngine;
using System.Collections;

public class loadingRue : MonoBehaviour {

	public float loadingTime = 1;

	IEnumerator Start () {
		yield return new WaitForSeconds( loadingTime);
		Application.LoadLevel("Menu");
	}
}
