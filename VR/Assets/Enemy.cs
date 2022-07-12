using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public SimpleShoot shooter;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.forward = Vector3.ProjectOnPlane((Camera.main.transform.position = transform.position), Vector3.up).normalized;
    }
    void Shoot()
    {
        shooter.Shoot();
    }
}
