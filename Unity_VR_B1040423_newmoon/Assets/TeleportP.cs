using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportP : MonoBehaviour
{
    public Animator ani;
    public GameObject OBJ;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider"&&GameM.haveK)
        {

            OBJ.SetActive(true);
        }
        
    }
}
