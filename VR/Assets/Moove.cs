using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moove : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetTrigger("Enemy");
    }

    // Update is called once per frames
    void Update()
    {
        
    }
}
