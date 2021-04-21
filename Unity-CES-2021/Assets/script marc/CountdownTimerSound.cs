using UnityEngine;
using System.Collections;

public class CountdownTimerSound : CountdownTimer {
	public AudioSource audioSource;

	protected override void OnStart ()
	{
		base.OnStart ();
		if (audioSource == null)
			audioSource = gameObject.GetComponent<AudioSource> ();
	}
	
	protected override void OnTimerStart (float delay)
	{
		// ensure that the sound is stopped
		audioSource.Stop ();
		audioSource.time = delay; 

		audioSource.Play ();

		Debug.LogFormat ("Play sound '{0}' at {1}", audioSource.name, delay);
	}
}