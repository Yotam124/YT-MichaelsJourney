﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAndArrow : MonoBehaviour
{
    private Rigidbody myBody;

    public float speed = 30f;

    public float deactivateTimer = 3f;

    public float damage = 15f;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Invoke("DeactivateGameObject", deactivateTimer);
    }
    
    public void Launch(Camera mainCamera)
    {
        myBody.velocity = mainCamera.transform.forward * speed;

        transform.LookAt(transform.position + myBody.velocity);
    }

    void DeactivateGameObject()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    { // after we touched an enemy, deactivate gameObject

    }
}
