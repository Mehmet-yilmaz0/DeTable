using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    public KeyCode Right;
    public KeyCode Up;
    public KeyCode Down;
    public KeyCode Left;

    public float speed=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        leftMove(Left);
        rightMove(Right);
        upMove(Up);
        downMove(Down);
    }

    private void downMove(KeyCode down)
    {
        if(Input.GetKey(down))
        {
            Vector3 velocity = new Vector3(0, -1);
            this.transform.position += velocity * speed * Time.deltaTime;
        }
    }

    private void upMove(KeyCode up)
    {
        if (Input.GetKey(up))
        {
            Vector3 velocity = new Vector3(0, 1);
            this.transform.position += velocity * speed * Time.deltaTime;
        }
    }

    private void rightMove(KeyCode right)
    {
        if (Input.GetKey(right))
        {
            Vector3 velocity = new Vector3(1, 0);
            this.transform.position += velocity * speed * Time.deltaTime;
        }
    }

    private void leftMove(KeyCode left)
    {
        if (Input.GetKey(left))
        {
            Vector3 velocity = new Vector3(-1, 0);
            this.transform.position += velocity * speed * Time.deltaTime;
        }
    }
}
