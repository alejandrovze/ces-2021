using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Darken the light completely over a period of 2 seconds.
    void Update()
    {
        lt.color -= (Color.white / 2.0f) * Time.deltaTime;
    }
}
