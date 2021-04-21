using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    public float speed = 1f;
    public float circleRad = 1f;

    private Vector3 fixedPoint;
    private float currentAngle;
    // Start is called before the first frame update
    void Start()
    {
      fixedPoint = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
    	 currentAngle += speed * Time.deltaTime;
          Vector2 offset = new Vector2 (Mathf.Sin (currentAngle), Mathf.Cos (currentAngle)) * circleRad;
          Vector3 pos = new Vector3 (fixedPoint.x + offset.x, fixedPoint.y, fixedPoint.z + offset.y); 
          transform.position = pos;
    }
}