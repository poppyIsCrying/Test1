using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClonable<T>
{
    T Clone(T prototype);
}