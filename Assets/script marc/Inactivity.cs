using UnityEngine;
using System.Collections;

public class Inactivity : MonoBehaviour {
	public int level;
	public float inactivty;
	private float _lastActivty;
	private bool _doOnce;
	
	// Use this for initialization
	void Start () {
		_lastActivty = Time.timeSinceLevelLoad; 
		_doOnce = false;
	}
	
	// Update is called once per frame
	void Update () {	
		var move = Mathf.Abs (Input.GetAxis ("Horizontal")) + Mathf.Abs (Input.GetAxis ("Vertical"));
		if (move > 0)
			_lastActivty = Time.timeSinceLevelLoad;
		else {
			var ts = Time.timeSinceLevelLoad - _lastActivty;
			if ( inactivty > 0 &&  ts > inactivty) {
				Debug.LogFormat("No activty since {0:0.00} seconds. We go to the level {1}", ts, level);
				_doOnce = true;
			}
		}

		if ( _doOnce ){
			Application.LoadLevel(level);
			_doOnce = false;
		}
	}
}
