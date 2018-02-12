using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public Animator anim;
    public AudioSource gunshotSound;
    public float triggerAxis;

    //public bool canBeFired;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))  //canBeFired )
        {
            FireGun();
        }

        anim.SetFloat("fTriggerAxis", Input.GetAxis("Horizontal"));

        if (Input.GetAxis("Horizontal") >= 0.9f)
        {
            FireGun();
            //triggerAxis = 0;

        }

    }

    public void FireGun()
    {

        //canBeFired = false;

        anim.SetTrigger("pShoot");

        print("Shoot!");



    }

    public void PlaySound()
    {
        gunshotSound.Play();
        anim.SetBool("bShoot", false);
    }

    public void switchState()
    {
        //canBeFired = true;
    }

        


}
