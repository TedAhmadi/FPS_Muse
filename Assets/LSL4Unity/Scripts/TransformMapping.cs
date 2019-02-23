using Assets.LSL4Unity.Scripts.AbstractInlets;
using UnityEngine;
using System;
using System.Linq;

public class TransformMapping : AFloatInlet
{
    public Transform targetTransform;
    public string lastSample = String.Empty;
    public static float currentConcentrate;

    protected override void Process(float[] newSample, double timeStamp)
    {
        lastSample = string.Join(" ", newSample.Select(c => c.ToString()).ToArray());
        //Assuming that a sample contains at least 3 values for x,y,z 12 chanells
        float x = newSample[0];
        float y = 90 ;// newSample[1];
        float z = 0;// newSample[2];
        x = x * 100f; 
        currentConcentrate = x;
        if (x > 40)
        {

            //Debug.Log(string.Format("Value {0}", lastSample));
            // we map the coordinates to a rotation
            var targetRotation = Quaternion.Euler(x, y, z);

            // apply the rotation to the target transform
            targetTransform.rotation = targetRotation;
        }
    }
}
