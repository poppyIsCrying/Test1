using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FactoryMethod : MonoBehaviour
{
    FerrariFactory ferrariFactory = new FerrariFactory();
    void Start()
    {
        Car myCar1 = ferrariFactory.GetProduct();
        myCar1.Drift();
    }
}

interface CarFactory
{
    Car GetProduct();
}

public class FerrariFactory : CarFactory
{
    public Car GetProduct()
    {
        return new Ferrari("Ferrari", 200f);
    }
}

public class Car
{
    public string Name { get; set; }
    public float Speed { get; set; }

    public Car(string n, float s)
    {
        Name = n;
        Speed = s;
    }

    public virtual void Drift()
    {
        Debug.Log("[Car]" + Name + " is drifting!");
    }
}

public class Ferrari : Car
{
    public Ferrari(string name, float speed) : base(name, speed)
    {

    }

    public override void Drift()
    {
        Debug.Log("[Ferrari]" + Name + " is drifting!");
    }
}

public class Bugatti : Car
{
    public Bugatti(string name, float speed) : base(name, speed)
    {

    }

    public override void Drift()
    {
        Debug.Log("[Bugatti]" + Name + " is drifting!");
    }


}