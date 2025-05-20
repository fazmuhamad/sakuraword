using UnityEngine;
using System.Collections;

public class moveOffset : MonoBehaviour {

	private Material materialAtual;
	public float kecepatan;
	private float offset;


	// Use this for initialization
	void Start () {
		materialAtual = GetComponent<Renderer>().material;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		offset += 0.001f;

		materialAtual.SetTextureOffset("_MainTex", new Vector2(offset  * kecepatan,0)); 
	
	}
}
