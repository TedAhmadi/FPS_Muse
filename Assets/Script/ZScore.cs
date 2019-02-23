using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.XR.WSA.Input;

public class ZScore : MonoBehaviour {

    //public static GameObject MM;

    public static MotionControllerInfo rightController;
    //public GameObject controllerParent;
    //public InteractionSourceHandedness handedness;

    void Start()
    {
        //rightController = new MotionControllerInfo();// (controllerParent, handedness);
    }
    


    public static void DeductedPoints()
    {

        float TargetDistance;
        float AllowedRange = 15;

        GameObject m = GameObject.FindWithTag("target003");
        //GameObject n = GameObject.FindWithTag("target002");
        //GameObject t = GameObject.FindWithTag("target001");
        //m.transform.position;
        //Debug.Log(string.Format("m:   ")+m.ToString()+"n:   "+ n.ToString()+"t:   "+ t.ToString());
        //if (rightController != null)
        //{
            //Debug.Log(string.Format("RightController......") + rightController.select.transform.localPosition);// .AlternateRightController.transform.position);
        //}
        Debug.Log(string.Format("m......")+ m.transform.position +"m direct"+ m.transform.TransformDirection(Vector3.forward));
        /*
        RaycastHit Shot;
        if (Physics.Raycast(m.transform.position, TT.AlternateRightController.transform.TransformDirection(Vector3.forward), out Shot))
        {
            Debug.Log(string.Format("TT......") + TT.AlternateRightController.transform.position);
            TargetDistance = Shot.distance;
            Debug.Log(string.Format("TargetDistance: ") + TargetDistance);
            if (TargetDistance < AllowedRange)
            {
                //Shot.transform.SendMessage("DeductPoints");
                Debug.Log(string.Format("Hit cilbbb2222......"));
            }
        }

        /*
        if (GameObject.FindWithTag("target003"))
        {
            GlobalScore.CurrentScore += 100;
            Debug.Log(string.Format("target003 Hit ......"));
        }
        else if (GameObject.FindWithTag("target002"))
        {
            GlobalScore.CurrentScore += 50;
            Debug.Log(string.Format("target002 Hit ......"));
        }
        else if (GameObject.FindWithTag("target001"))
        {
            GlobalScore.CurrentScore += 25;
            Debug.Log(string.Format("target001 Hit ......"));
        }
        */
    }
}
