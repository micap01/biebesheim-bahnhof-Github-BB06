using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRYesPLease : MonoBehaviour {
    

	public void Start () {
        StartCoroutine(ActivatorVR("cardboard"));
    }

    public IEnumerator  ActivatorVR(string YESVR)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }
}
