using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public static bool haveK;

    public void pick()
    {

    }
    public void Npick(GameObject obj)
    {
        haveK = true;
        Destroy(obj);
    }
    public void holde()
    {

    }
}
