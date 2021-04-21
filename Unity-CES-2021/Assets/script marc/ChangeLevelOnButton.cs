using UnityEngine;
using System.Collections;

public class ChangeLevelOnButton : MonoBehaviour {
	public int level;
	public string button;
	private bool _doOnce;

	// Use this for initialization
	void Start () {
		_doOnce = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp (button))
			_doOnce = true;
		
		if ( _doOnce ){
			Debug.LogFormat("The button '{0}' has been pressed. We go to the level {1}", button, level);
			Application.LoadLevel(level);
			_doOnce = false;
		}
	}
}
