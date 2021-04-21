using UnityEngine;
using System.Collections;

public class ChangeLevelOnAxis : MonoBehaviour {
	public enum Direction {
		Up,
		Down,
		Left,
		Right
	}

	public int level;
	public Direction direction;

	private bool _doOnce;
	private string _axisName;
	private bool _isNegative;

	// Use this for initialization
	void Start () {
		_doOnce = false;

		switch (direction){
		case Direction.Up:
		case Direction.Down: 
			_axisName = "Vertical";
			break;

		case Direction.Left:
		case Direction.Right: 
			_axisName = "Horizontal";
			break;
		}

		_isNegative = (direction == Direction.Left || direction == Direction.Down  );
	}
	
	// Update is called once per frame
	void Update () {	
		float v = Input.GetAxis (_axisName);
		if ( _isNegative )
			v = Mathf.Abs(v);
	
		if ( v > 0  )
			_doOnce = true;
		
		if ( _doOnce ){
			Debug.LogFormat("The joystick is on direction '{0}'. We go to the level {1}", direction.ToString(), level);
			Application.LoadLevel(level);
			_doOnce = false;
		}
	}
}
