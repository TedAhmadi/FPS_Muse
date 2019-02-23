using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.VR;
using UnityEngine.XR;

public class HandGunDamage : MonoBehaviour {

    [SerializeField] public static Vector3 corsurePosition, tempPosition, currentPosition;

    [SerializeField] public static Vector3 head;

    [SerializeField] public static Vector3 corsureRotation;

    GameObject visualGun;
    AudioSource gunsound;
    //GunFire muzzleFlash;

    public ParticleSystem muzzleFlash;

    // Update is called once per frame
    //public visualgun gunwork;
    void start()
    {
        gunsound = new AudioSource();
        muzzleFlash = GetComponent<ParticleSystem>();
        muzzleFlash.Stop();
    }

    void Update () {

        gunsound = GetComponent<AudioSource>();
        corsurePosition = transform.position;
        tempPosition = transform.position;

        corsurePosition = InputTracking.GetLocalPosition(XRNode.RightHand);
        head = InputTracking.GetLocalPosition(XRNode.Head);
        
        corsureRotation.x = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles.x;
        corsureRotation.y = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles.y;
        corsureRotation.z = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles.z;

        Vector3 forwardVector = Quaternion.Euler(corsureRotation) * Vector3.forward;
        //Debug.Log(string.Format(" corsurePosition: ") + corsurePosition);

        currentPosition = corsurePosition + tempPosition;

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, currentPosition);
        lineRenderer.SetPosition(1, currentPosition);
        //lineRenderer.SetPosition(1, forwardVector * 15 + currentPosition);
        if (TransformMapping.currentConcentrate >= 50.0f)
        {

            if (Input.GetKeyDown("joystick button 15")) // Input.GetKey("joystick button 15"))
            {
                lineRenderer.SetPosition(0, currentPosition);
                lineRenderer.SetPosition(1, forwardVector * 15 + currentPosition);
                muzzleFlash.Play();
                //muzzleFlash = GetComponent<GunFire>();
                //muzzleFlash.muzzleFlashFire(currentPosition);
                gunsound.Play();
                Debug.Log(string.Format(" corsurePosition: ") + corsurePosition + " tempPosition: " + tempPosition + " oooo:" + currentPosition);
                RaycastHit Shot;
                if (Physics.Raycast(currentPosition, forwardVector, out Shot))
                {
                    Debug.Log(string.Format(" corsure Position: ") + corsurePosition + " Head:  " + head + " forwardVector:   " + forwardVector);// + TargetDistance);
                    //Debug.Log(string.Format(" MixedReality_Cam.forward: ") + MixedReality_Cam.transform.forward + "  corsureRotation: " + corsureRotation + " forwardVector: " + forwardVector);

                    Target target = Shot.transform.GetComponent<Target>();

                    if (target != null)
                    {
                        Debug.Log(string.Format("Destroyed......"));
                        target.TakeDamage(Shot);
                        if (Shot.transform.name.Equals("Target003"))
                        {
                            GlobalScore.CurrentScore += 50;
                        }
                        else if (Shot.transform.name.Equals("Target002"))
                        {
                            GlobalScore.CurrentScore += 100;
                        }
                        else if (Shot.transform.name.Equals("Target001"))
                        {
                            GlobalScore.CurrentScore += 200;
                        }
                        else { }
                    }

                    Debug.Log(Shot.transform.name);

                }
            }

        }//else { }
	}
}
