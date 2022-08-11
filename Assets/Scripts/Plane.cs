using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (transform.position.y < 20)
        {
            //transform.Translate(0, 10 * Time.deltaTime, 0); // plane fly
            vRB.AddForce(Vector3.up * 10 * Time.deltaTime, ForceMode.Impulse);
        }
    }

    protected override void MoveBack()
    {
        //transform.Translate(Vector3.forward * (speed / 10) * Time.deltaTime); // plane can not reverse
        vRB.AddForce(Vector3.zero * (speed / 10) * Time.deltaTime, ForceMode.Impulse);
    }

    protected override void SayName()
    {
        Debug.Log("My Plane Name is: " + name + ", year: " + year);
    }
}
