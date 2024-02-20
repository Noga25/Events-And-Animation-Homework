using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public ClipModifier theClipMod;
    public Events eventList;
   
    void Update()
    {
        //Changing state to waking
        if (Input.GetKey(KeyCode.C))
        {
            eventList.MovementHandler.AddListener(theClipMod.IdleOff);
            eventList.MovementHandler.AddListener(theClipMod.StopRunning);
            eventList.MovementHandler.AddListener(theClipMod.ChangeWalkingSpeed);
            eventList.MovementHandler.Invoke();
        }

        //Changing state to running
        if (Input.GetKey(KeyCode.P))
        {
            eventList.MovementHandler.AddListener(theClipMod.IdleOff);
            eventList.MovementHandler.AddListener(theClipMod.ChangeRunningSpeed);
            eventList.MovementHandler.Invoke();
        }

        //Changing state to Idle
        if (Input.GetKey(KeyCode.I))
        {
            eventList.MovementHandler.AddListener(theClipMod.IdleOn);
            eventList.MovementHandler.AddListener(theClipMod.StopRunning);
            eventList.MovementHandler.AddListener(theClipMod.StopWalking);
            eventList.MovementHandler.Invoke();
        }
    }
   
}
