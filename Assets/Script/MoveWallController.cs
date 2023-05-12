using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour
{
    private Vector3 pos;
    public bool is2ndFloor;

    void Start()
    {
        is2ndFloor = false;
    }

    //2�K�֏㏸
    public void MoveUp()
    {
        StartCoroutine("MoveUpStart");
    }

    IEnumerator MoveUpStart()
    {
        while (pos.y < 3.0f)
        {
            pos = transform.position;
            transform.Translate(0, 0.02f, 0);
            yield return new WaitForSeconds(0.01f);
        }
        is2ndFloor = true;
    }

    //1�K�։��~
    public void MoveDown()
    {
        StartCoroutine("MoveDownStart");

    }

    IEnumerator MoveDownStart()
    {
        while (pos.y > 0.0f)
        {
            pos = transform.position;
            transform.Translate(0, -0.02f, 0);
            yield return new WaitForSeconds(0.01f);
        }
        is2ndFloor = false;
    }
}