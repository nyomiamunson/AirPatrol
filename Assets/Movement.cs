using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speedMin = 2f;
    [SerializeField] float speedMax = 5f;

    float speed;
    Vector2 direction;

    void Start()
    {
        // Randomize speed and direction
        speed = Random.Range(speedMin, speedMax);
        direction = Random.insideUnitCircle.normalized;
    }

    void Update()
    {
        // Move the imposters & crewmates
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
