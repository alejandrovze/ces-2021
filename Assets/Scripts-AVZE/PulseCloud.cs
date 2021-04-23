using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseCloud : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    public float speed = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
      	m_Rigidbody.AddForce(-m_Thrust, m_Thrust, -m_Thrust);
    }

    void FixedUpdate()
    {
		// m_Rigidbody.velocity = m_Rigidbody.velocity.normalized * speed;
    }

}
