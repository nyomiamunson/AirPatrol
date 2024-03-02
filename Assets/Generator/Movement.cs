using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speedMin = 2f;
    [SerializeField] float speedMax = 5f;
    [SerializeField] GameObject explosionGO;

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Detect collisions of the player ship with an imposter or crewmate
        if ((collision.tag == "PlayerShip") || (collision.tag == "PlayerBullet"))
        {
            PlayExplosion();
            Destroy(gameObject);
        }
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(explosionGO);

        // Set the position of the explosion
        explosion.transform.position = transform.position;
    }
}
