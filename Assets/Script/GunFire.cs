using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
    public ParticleSystem muzzleFlash;
    // Use this for initialization
    void Start () {
        muzzleFlash = GetComponent<ParticleSystem>();
        muzzleFlash.Stop();
    }

    // Update is called once per frame
    public void muzzleFlashFire( Vector3 currentPosition)
    {
        Debug.Log(string.Format("Destroyed DDDDDDDDDD......") + muzzleFlash.transform.position);
        muzzleFlash.transform.position = currentPosition;// .transform.position;
        Debug.Log(string.Format("Destroyed DDDDDDDDDD......") + currentPosition + " muzzleFlash: "+ muzzleFlash.transform.position);
        muzzleFlash.Play();
    }
}
