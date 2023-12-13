using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish3 : MonoBehaviour
{

    float min = -10;
    float max = 10;
    float randomizedNum;

    bool random_moving_flag = false;

    public static bool catched_flag = false;
    void Start()
    {
        //InvokeRepeating("rotateHead", 1.0f, 5f);

        StartCoroutine("Random_Moving");
    }


    void Update()
    {
        if (catched_flag == false)
        {
            randomizedNum = Random.Range(min, max);
            moveForward();
            rotateHead();
        }
        else if(catched_flag == true)
        {
            StopCoroutine("Random_Moving");
        }
    }

    void moveForward()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime);
    }

    void rotateHead()
    {
        if (random_moving_flag == true)
        {
            random_moving_flag = false;
            this.transform.Rotate(Vector3.up, 100);
            Debug.Log(randomizedNum);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "wall") 
        {
            this.transform.Rotate(Vector3.up, 180);
            Debug.Log("ºÎµúÈû");
        }            

    }

    private IEnumerator Random_Moving()
    {
        while (true) 
        { 
            int randtime = (int)Random.Range(2, 8);
            yield return new WaitForSeconds(randtime);
            random_moving_flag = true;
        }
    }


    /*private void OnTriggerExit(Collider other)
    {
        this.transform.Rotate(Vector3.up, -180);
        Debug.Log("ºÎµúÈû");

    }*/
}
