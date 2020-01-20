using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneTesting : MonoBehaviour
{

    void Start()
    {
        Entity e1 = new Entity("Lol1");
        Entity e2 = e1.Clone(e1);
        Entity e3 = e1.Clone(e1);
    }

}

public class Entity : IClonable<Entity>
{
    string description;

    public Entity(string d)
    {
        description = d;
    }

    public Entity()
    {
        description = "";
    }

    public Entity Clone(Entity prototype)
    {
        Entity clone = new Entity();
        clone.description = prototype.description;

        //return (Entity)this.MemberwiseClone();
        return clone;
    }
}
