using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class StarBehaviour : MonoBehaviour
{
    public float verticalSpeed = 0.02f;
    public Boundary boundary;
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

    public void Move()
    {
        transform.position = new Vector3(0, verticalSpeed, 0);

    }

    public void CheckBounds()
    {
        if(transform.position.y > boundary.min)
        {
            ResetStars();
        }
    }

    public void ResetStars()
    {
        transform.position = new Vector2(0, boundary.max);
    }
}
