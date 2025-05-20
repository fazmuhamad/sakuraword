using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	bool isMute;

	void Awake(){
		DontDestroyOnLoad(gameObject);
	}
	public void Mute (){
		isMute = ! isMute;
			AudioListener.volume =  isMute ? 0 : 1;
	}
}
