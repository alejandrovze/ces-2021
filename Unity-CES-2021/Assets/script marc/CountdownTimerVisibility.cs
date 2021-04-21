using UnityEngine;
using System.Collections;

public class CountdownTimerVisibility : CountdownTimer {
	public enum VisibilityState
	{
		Hidden,
		Visible,
	}

	public GameObject hidden;
	public VisibilityState desiredState;

	private Renderer[] _renderers;

	void ChangeVisibility (bool state)
	{
		foreach( var r in _renderers )
			r.enabled = state;
	}

	protected override void OnStart ()
	{
		base.OnStart ();
		if (hidden == null)
			hidden = gameObject;

		_renderers = hidden.GetComponentsInChildren<Renderer>();
	}

	protected override void OnTimerStart (float delay)
	{
		switch (desiredState) {
		case VisibilityState.Hidden:
			ChangeVisibility(false);
			break;

		case VisibilityState.Visible:
			ChangeVisibility(true);
			break;
		}

		Debug.LogFormat ("Set {0}'s state to {1}", gameObject.name, desiredState);
	}
}