using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    protected override void SayName()
    {
        Debug.Log("My Car Name is: " + name);
    }
}
