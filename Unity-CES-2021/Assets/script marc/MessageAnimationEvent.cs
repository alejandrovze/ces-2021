using UnityEngine;
using System.Collections;

public class MessageAnimationEvent : MonoBehaviour
{
	public GameObject receiver;

	// Use this for initialization
	void Start ()
	{
			if (receiver == null)
					receiver = gameObject;
	}


	public void NewMessage (string message)
	{
			receiver.BroadcastMessage (message);
	}
}
