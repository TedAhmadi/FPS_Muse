using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class visualgun : MonoBehaviour {

    //GameObject visualGun;
    [SerializeField] public static Vector3 corsurePositio, tempPositio, currentPositio;
    [SerializeField] public static Vector3 corsureRotatio;

    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        //lineRenderer.SetVertexCount(1);
    }

        void Update()
    {
        corsurePositio = transform.position;
        //tempPositio = transform.position;

        corsurePositio = InputTracking.GetLocalPosition(XRNode.RightHand);

        corsureRotatio.x = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles.x;
        corsureRotatio.y = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles.y;
        corsureRotatio.z = InputTracking.GetLocalRotation(XRNode.RightHand).eulerAngles.z;
        //corsureRotatio.x += 30f;

        Vector3 forwardVector = Quaternion.Euler(corsureRotatio) * Vector3.forward;

        //Debug.Log(string.Format(" corsureRotation: ") + corsureRotation.x +" , "+ corsureRotation.y + " , " + corsureRotation.z);

        //currentPositio = corsurePositio + tempPositio;
        Debug.Log(string.Format(" corsurePosition: ") + corsurePositio + " tempPosition: " + tempPositio + " currentPosition: " + currentPositio);
        transform.position = corsurePositio;// + new Vector3(0.5f, -1, 0);
        transform.rotation = Quaternion.Euler(corsureRotatio);
        //tempPositio = corsurePositio + new Vector3(0.5f, -1, 0);

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, forwardVector * 15 + transform.position);

        //transform.position = corsurePosition + one;

    }
    
}
