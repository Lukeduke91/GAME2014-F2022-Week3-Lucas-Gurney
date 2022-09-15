using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 2.0f;
    public Boundary boundary;
    public float verticalPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        CheckBounds();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;

        transform.position += new Vector3(x, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, boundary.min, boundary.max), verticalPosition);
        //float clampedXPosition = Mathf.Clamp(transform.position.x, boundary.min, boundary.max);
    }

    void CheckBounds()
    {
        if (transform.position.x > boundary.max)
        {
            transform.position = new Vector2(boundary.max, verticalPosition);
        }
        if (transform.position.x < boundary.max)
        {
            transform.position = new Vector2(boundary.max, verticalPosition);
        }
        //Mathf.Clamp();
    }
}
