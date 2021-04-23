using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
	public int minTime = 1;
	public int maxTime = 10;

    AudioSource source;
	 
	void Start()
	{
   		source = gameObject.GetComponent<AudioSource>();
   		triggerSound();
	}
	 
    // Update is called once per frame
    void triggerSound()
    {
   		float delayTime = (float) Random.Range(minTime * 100, maxTime * 100) / 100f;
   		Debug.Log("delay time " + delayTime);
        StartCoroutine(DelayPlay(delayTime));
    }

    IEnumerator DelayPlay(float delay)
    {
        yield return new WaitForSeconds(delay);
        source.Play();
        triggerSound();
    }
}