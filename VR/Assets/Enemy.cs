using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void SetupRagdoll()
    {

    }
   void Dead(Vector3 hitpoint)
    {
        GetComponent<Animator>().enabled = false;
 
    }
}
