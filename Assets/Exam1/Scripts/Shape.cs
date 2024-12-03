using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    
    protected string ShapeName
    {
        get
        {
            return shapeName;
        }
        set
        {
            value = shapeName;
            
        }
    }
    string init(string shapeName)
    {

    }
}

