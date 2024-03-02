using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    float futureTime = 0; // This is the time when we will instatiate a baby or demon

    [SerializeField] float minTime = -1f;
    [SerializeField] float maxTime = 1f;

    [SerializeField] GameObject stevePrefab;
    [SerializeField] GameObject dragonPrefab;
    [SerializeField] int Dragon2SteveRatio = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > futureTime)
        {
            futureTime = Time.time + Random.Range(minTime, maxTime);
            int r = Random.Range(0, 500);
            if (r < Dragon2SteveRatio)
            {
                Instantiate(dragonPrefab, transform.position, transform.rotation);
            }
            else
            {
                Instantiate(stevePrefab, transform.position, transform.rotation);
            }

        }
    }
}
