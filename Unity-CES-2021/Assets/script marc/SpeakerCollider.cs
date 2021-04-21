using UnityEngine;
using System.Collections;

public class SpeakerCollider : MonoBehaviour {
	public string tagName;
	public AudioSource audioSource;
	public bool isStoppedWhenEnterAgain;

	void OnTriggerEnter (Collider other) {
		if (other.tag == tagName) {
			Debug.LogFormat("Collide between {0} and {1}", tagName, gameObject.name);			
			if ( audioSource != null && audioSource.isActiveAndEnabled ){
				if ( audioSource.isPlaying && isStoppedWhenEnterAgain ) {
					Debug.LogFormat("Stopping {0}", audioSource.name );			
					audioSource.Stop();
				}
				else
				{
					Debug.LogFormat("Playing {0}", audioSource.name );			
					audioSource.Play();
				}
			}
		}
	}
}
