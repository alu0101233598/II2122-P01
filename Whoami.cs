using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whoami : MonoBehaviour
{
    public int id = 0;
    private int count = 1;

    // Update is called once per frame
    void Update()
    {
        string name = gameObject.name;
        string tag = gameObject.tag;
        Debug.Log(string.Format("Hi! I'm {0} ({1}), with ID {2}. This is my {3}º message!", name, tag, id, count));
        count++;
    }
}
