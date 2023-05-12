using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Vector3 start, end;
    private bool up, down;
    public float speed;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
       start = transform.position;
       end = transform.position + new Vector3(0,8,0);
       dir = new Vector3(0,speed,0);
        up =true;
        down = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            transform.Translate(dir * Time.deltaTime);

            if(transform.position.y >= 8)
            {
                up = false;
                down = true;
            }
        }
        if (down)
        {
            transform.Translate(-dir * Time.deltaTime);
            if(transform.position.y <= -1)
            {
                up = true;
                down = false;
            }
        }
    }
}
