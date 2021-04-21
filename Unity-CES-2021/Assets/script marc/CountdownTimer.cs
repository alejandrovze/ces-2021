using UnityEngine;
using System.Collections;


public abstract class CountdownTimer : MonoBehaviour {
	public float NumberOfSecondsToWait;
	private bool isTiming = false;
	private float timer;
	
	// Use this for initialization
	void Start () {
		OnStart ();
		
		timer = Time.timeSinceLevelLoad + NumberOfSecondsToWait;
		isTiming = true;	
	}
	
	// Update is called once per frame
	void Update () {
		if (isTiming) {
			var current = Time.timeSinceLevelLoad;
			if ( timer < current ){
				isTiming = false;
				Debug.Log("Start Timer Event");
				
				OnTimerStart(current - timer);
			}	
		}
	}
	
	protected virtual void OnStart(){}
	protected abstract void OnTimerStart(float delay);
}
