using UnityEngine;
using System.Collections;

public class CountdownTimerLight : CountdownTimer {
	public enum SwitchState
	{
		Off,
		On,
	}
	
	public GameObject objectLight;
	public SwitchState desiredState;
	
	private Light[] _lights;
	
	void ChangeVisibility (bool state)
	{
		foreach( var l in _lights )
			l.enabled = state;
	}
	
	protected override void OnStart ()
	{
		base.OnStart ();
		if (objectLight == null)
			objectLight = gameObject;
		
		_lights = objectLight.GetComponentsInChildren<Light>();
	}
	
	protected override void OnTimerStart (float delay)
	{
		switch (desiredState) {
		case SwitchState.Off:
			ChangeVisibility(false);
			break;
			
		case SwitchState.On:
			ChangeVisibility(true);
			break;
		}
		
		Debug.LogFormat ("Set {0}'s light state to {1}", gameObject.name, desiredState);
	}
}
