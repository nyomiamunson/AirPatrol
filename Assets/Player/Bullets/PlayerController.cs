using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float maxY = 4f;
    [SerializeField] float minY = -4f;

    [SerializeField]
    private GameObject playerBullet;

    [SerializeField]
    private Transform attackPoint;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the paddle up when W key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        // Move the paddle down when S key is pressed
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        // Move the paddle up when up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        // Move the paddle down when down arrow key is pressed
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        //Peg movement to maxY
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0);
        }
        //Peg movement to minY
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0);
        }

        Attack();
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(playerBullet, attackPoint.position, Quaternion.identity);
        }
    }
}