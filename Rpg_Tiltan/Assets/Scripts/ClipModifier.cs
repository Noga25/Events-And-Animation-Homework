using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipModifier : MonoBehaviour
{

    public Animator runningVegas;
    public float RunningSpeed;
    public float WalkingSpeed;
   
    //States methods
    public void IdleOff()
    {
        runningVegas.SetBool("IsIdle", false);
    }

    public void IdleOn()
    {
        runningVegas.SetBool("IsIdle", true);
    }

    public void ChangeRunningSpeed()
    {
        runningVegas.SetFloat("RunningSpeed", RunningSpeed);
    }

    public void StopRunning()
    {
        runningVegas.SetFloat("RunningSpeed", 1);
    }

    public void ChangeWalkingSpeed()
    {
        runningVegas.SetFloat("WalkingSpeed", WalkingSpeed);
    }
    
    public void StopWalking()
    {
        runningVegas.SetFloat("WalkingSpeed", 1);
    }



   


}
