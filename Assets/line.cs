using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    LineRenderer lr;
    public GameObject Pos0Ref, Pos1Ref;
    Vector3 cube1Pos, cube2Pos;

    public bool start_flag = false;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.startWidth = .01f;
        lr.endWidth = .01f;

        //cube1Pos = gameObject.GetComponent<Transform>().position;
    }

    void Update()
    {
        if (start_flag == true)
        {
            lr.SetPosition(0, Pos0Ref.GetComponent<Transform>().position);
            lr.SetPosition(1, Pos1Ref.GetComponent<Transform>().position);
        }
        else if(start_flag == false)
        {
            lr.SetPosition(0, Pos0Ref.GetComponent<Transform>().position);
            lr.SetPosition(1, Pos0Ref.GetComponent<Transform>().position);
        }

    }

}
