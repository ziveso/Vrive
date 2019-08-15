﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRControllerLeft : Abstract_VRController
{
    public override void BackingDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        DDebug.Instance.Log("Backing down");
        Debug.Log("Backing down");
        isBacking = true;
    }

    public override void BackingUp(SteamVR_Action_Boolean fromActive, SteamVR_Input_Sources fromSource)
    {
        DDebug.Instance.Log("Backing Up");
        Debug.Log("Backing Up");
        isBacking = false;
    }

    public override void BreakingDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        DDebug.Instance.Log("Breaking down");
        Debug.Log("Breaking down");
        isBreaking = true;
    }

    public override void BreakingUp(SteamVR_Action_Boolean fromActive, SteamVR_Input_Sources fromSource)
    {
        DDebug.Instance.Log("Breaking Up");
        Debug.Log("Breaking Up");
        isBreaking = false;
    }
}
