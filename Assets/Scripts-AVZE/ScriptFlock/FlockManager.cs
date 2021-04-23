using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour


{
    public GameObject fishPrefab;
    public GameObject fishDaddy;
    public int numFish = 20;
    public GameObject[] allFish;
    public Vector3 swimLimits = new Vector3(5, 5, 5);

    [Header("Fish Setting")]
    [Range(0.0f, 5.0f)] public float minSpeed;
    [Range(0.0f, 5.0f)] public float maxSpeed;
    [Range(1.0f, 10.0f)]public float neighbourDistance;
    [Range(0.0f, 5.0f)] public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        allFish = new GameObject[numFish];
        for (int i = 0; i < numFish; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(
             Random.Range(- swimLimits.x, swimLimits.x),
             Random.Range(- swimLimits.z, swimLimits.z),
             Random.Range(- swimLimits.y, swimLimits.y)

             );
            allFish[i] = (GameObject) Instantiate(fishPrefab, pos, Quaternion.identity);
            allFish[i].GetComponent<Flock>().myManager = this;
            allFish[i].transform.parent = fishDaddy.transform;

            AudioClip clip = allFish[i].GetComponent<Flock>().sound_samples[i];
            AudioSource source = allFish[i].GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();

    }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
