using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 2.0f;
    public Boundary boundary;
    public float verticalPosition;
    private Camera camera;
    // Start is called before the first frame update

    // Update is called once per frame
     void Start()
    {
        transform.position = new Vector2(0.0f, verticalPosition);
        camera = Camera.main;
    }
    void Update()
    {
        //Move();
        GetMobileInput();
        //float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        //float y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        //transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        transform.position += new Vector3(x, 0, 0);

        float clampedPosition = Mathf.Clamp(transform.position.x, boundary.min, boundary.max);
        transform.position = new Vector2(clampedPosition, verticalPosition);
    }

    void GetMobileInput()
    {
        //Touch currentTouch = new Touch();

        foreach (Touch touch in Input.touches) 
        { 
            //currentTouch = touch;
            transform.position = camera.ScreenToWorldPoint(touch.position);
        }
        //var touch = Input.GetTouch(0);
        

        float clampedPosition = Mathf.Clamp(transform.position.x, boundary.min, boundary.max);
        transform.position = new Vector2(clampedPosition, verticalPosition);
    }
    //void CheckBounds()
    //{
    //    if (transform.position.x > boundary.max)
    //    {
    //        transform.position = new Vector2(boundary.max, verticalPosition);
    //    }
    //    if (transform.position.x < boundary.max)
    //    {
    //        transform.position = new Vector2(boundary.max, verticalPosition);
    //    }
    //    //Mathf.Clamp();
    //}
}
