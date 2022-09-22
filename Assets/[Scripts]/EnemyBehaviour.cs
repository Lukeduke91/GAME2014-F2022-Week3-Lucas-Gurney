using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class EnemyBehaviour : MonoBehaviour
{
    public Boundary Horizontalboundary;
    public Boundary Verticalboundary;
    public float HorizontalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        var startingXPosition = Random.Range(Horizontalboundary.min, Horizontalboundary.max);
        var startingYPosition = Random.Range(Verticalboundary.min, Verticalboundary.max);
        HorizontalSpeed = Random.Range(0.1f, 4.0f);
        transform.position = new Vector3(startingXPosition, startingYPosition, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        var boundaryLength = Horizontalboundary.max - Horizontalboundary.min;
       transform.position = new Vector3(Mathf.PingPong(Time.time * HorizontalSpeed, boundaryLength) - Horizontalboundary.max, 
           transform.position.y, 0.0f); 
    }
}
