//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public class SteamVR_Input_ActionSet_Vehicle : Valve.VR.SteamVR_ActionSet
    {
        
        public virtual SteamVR_Action_Boolean Forwarding
        {
            get
            {
                return SteamVR_Actions.vehicle_Forwarding;
            }
        }
        
        public virtual SteamVR_Action_Boolean Backing
        {
            get
            {
                return SteamVR_Actions.vehicle_Backing;
            }
        }
        
        public virtual SteamVR_Action_Boolean Breaking
        {
            get
            {
                return SteamVR_Actions.vehicle_Breaking;
            }
        }
    }
}
