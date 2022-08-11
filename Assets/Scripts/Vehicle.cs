using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public new string name = "Vehicle";
    [SerializeField]
    protected int speed = 100;
    [SerializeField]
    protected bool selected = false;
    public int myYear = 0;
    protected int year
    {
        get;
        private set;
    }

    protected bool isForward = false;
    protected bool isBack = false;
    protected Rigidbody vRB;

    protected virtual void Start()
    {
        vRB = gameObject.GetComponent<Rigidbody>();
        year = myYear;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (!selected)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            isForward = true;
        } else if (Input.GetKeyUp(KeyCode.W))
        {
            isForward = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            isBack = true;
        } else if (Input.GetKeyUp(KeyCode.S))
        {
            isBack = false;
        }

        if (isForward)
        {
            Move();
        } else if (isBack)
        {
            MoveBack();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SayName();
        }
    }

    protected virtual void Move()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        vRB.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
    }


    protected virtual void MoveBack()
    {
        //transform.Translate(Vector3.back * speed * Time.deltaTime);
        vRB.AddForce(Vector3.back * speed * Time.deltaTime, ForceMode.Impulse);
    }

    protected virtual void SayName()
    {
        Debug.Log("My Name is: " + name);
    }
}
