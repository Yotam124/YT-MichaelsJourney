﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponAim
{
    NONE,
    SELF_AIM,
    AIM
}

public enum WeaponFireType
{
    SINGLE,
    MULTIPLE
}

public enum WeaponBulletType
{
    NONE,
    BULLET,
    ARROW,
    SPEAR
}


public class WeaponHandler : MonoBehaviour
{
    private Animator anim;

    public WeaponAim weaponAim;

    [SerializeField]
    private GameObject muzzleFlash;

    [SerializeField]
    private AudioSource shootSound, reloadSound;

    public WeaponFireType fireType;

    public WeaponBulletType bulletType;

    public GameObject attackPoint;


    void Awake()
    {
        anim = GetComponent<Animator>();    
    }
   
    public void ShootAnimation()
    {
        anim.SetTrigger(AnimationTags.SHOOT_TRIGGER);
    }

    public void Aim(bool canAim)
    {
        anim.SetBool(AnimationTags.AIM_PARAMETER, canAim);
    }

    void Turn_On_MuzzleFlash()
    {
        muzzleFlash.SetActive(true);
    }

    void Turn_Off_MuzzleFlash()
    {
        muzzleFlash.SetActive(false);
    }

    void Play_ShootSound()
    {
        shootSound.Play();
    }

    void Play_ReloadSound()
    {
        reloadSound.Play();
    }

    void Turn_On_AttackPoint()
    {
        attackPoint.SetActive(true);
    }
    void Turn_Off_AttackPoint()
    {
        if (attackPoint.activeInHierarchy)
        {
            attackPoint.SetActive(false);
        }
    }



}
