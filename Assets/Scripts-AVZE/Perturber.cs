using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perturber: MonoBehaviour
{
    public float speed = 1f;
    public float minCircleRad = 1f;
    public float maxCircleRad = 10f;

    private Vector3 fixedPoint;
    private float currentAngle;
    private float circleRad;
    private bool expanding = true;
    // Start is called before the first frame update
    void Start()
    {
      fixedPoint = transform.position;  
      circleRad = minCircleRad;
    }

    // Update is called once per frame
    void Update()
    {
    	 currentAngle += speed * Time.deltaTime;

       if (expanding) {
        if (circleRad < maxCircleRad) {
         circleRad += 0.01f;
        }
        else {
          expanding = false;
        }
        }
        else {
          if (circleRad > minCircleRad) {
            circleRad -= 0.01f;
          }
          else {
          expanding = true;
        }
        }
          Vector2 offset = new Vector2 (Mathf.Sin (currentAngle), Mathf.Cos (currentAngle)) * circleRad;
          Vector3 pos = new Vector3 (fixedPoint.x + offset.x, fixedPoint.y, fixedPoint.z + offset.y); 
          transform.position = pos;
    }
}