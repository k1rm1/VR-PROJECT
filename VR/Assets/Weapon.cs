using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(XRGrabInteractable))]
public class Weapon : MonoBehaviour
{
    [SerializeField] protected float shootingForce;
    [SerializeField] protected Transform bulletSpawn;
    [SerializeField] private float reacoilForce;
    [SerializeField] private float damage;

    private Rigidbody rigidBody;
    private XRGrabInteractable interactableWeapon;

    [Obsolete]
    private void Awake()
    {
        interactableWeapon = GetComponent<XRGrabInteractable>();
        rigidBody = GetComponent<Rigidbody>();
        SetupInteractableWeaponEvents();
    }

    [Obsolete]
    private void SetupInteractableWeaponEvents()
    {
        interactableWeapon.onSelectEnter.AddListener(PickUpWeapon);
        interactableWeapon.onSelectExit.AddListener(DropWeapon);
        interactableWeapon.onActivate.AddListener(StartShooting);
        interactableWeapon.onDeactivate.AddListener(StopShooting);
    }
    private void PickUpWeapon(XRBaseInteractor interactor)
    {
        interactor.GetComponent<MeshHidder>().Hide();
    }
    private void DropWeapon(XRBaseInteractor interactor)
    {
        interactor.GetComponent<MeshHidder>().Show();
    }
    protected virtual void StopShooting(XRBaseInteractor interactor)
    {
        throw new NotImplementedException();
    }

    protected virtual void StartShooting(XRBaseInteractor interactor)
    {
        throw new NotImplementedException();
    } 

   

    
    protected virtual void Shoot()
    {
        ApplyRecoil();
    }

    private void ApplyRecoil()
    {
        rigidBody.AddRelativeForce(Vector3.back * reacoilForce, ForceMode.Impulse);
    }
    public float GetShootingForce()
    {
        return shootingForce;
    }
    public float GetDamage()
    {
        return damage; 
    }
}
