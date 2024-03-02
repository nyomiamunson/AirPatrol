using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkgMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.025f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.left * speed);
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector2(18, transform.position.y);
    }
}
