using System.Collections;
using UnityEngine;

public class CountdownTimerEndLevel : CountdownTimer {
	public int level;
	
	protected override void OnTimerStart (float delay)
	{
		Debug.LogFormat ("Lifetime reached: we go the level {0} ", level);
		Application.LoadLevel(level);
	}
}
