using UnityEngine;
using System.Collections;

public class CountdownTimerAnimator : CountdownTimer {
	Animator animator;
	public string idle;
	public string state;
	int idleTagHash;
	int stateHash;
	
	protected override void OnStart ()
	{
		base.OnStart ();
		if (animator == null)
			animator = gameObject.GetComponent<Animator> ();

		idleTagHash = Animator.StringToHash (idle);	
		stateHash = Animator.StringToHash (state);
	}
	
	protected override void OnTimerStart (float delay)
	{
		// ensure that the sound is stopped
		AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo (0);
		if (stateInfo.tagHash == idleTagHash) {
			animator.PlayInFixedTime (stateHash, -1, delay);
			
			Debug.LogFormat ("Play animation '{0}' at {1}", state, delay);
		}
	}
}
