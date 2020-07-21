﻿using UnityEngine;
using System.Collections;
using Vuforia;

public class BackgroundPlane : MonoBehaviour {

	private bool mBackgroundWasSwitchedOff = false;

	// Update is called once per frame
	void Update () {
		if (!mBackgroundWasSwitchedOff) {
			BackgroundPlaneBehaviour bgPlane = GetComponent<BackgroundPlaneBehaviour> ();
			if (bgPlane.enabled) {
				// switch it off
				bgPlane.enabled = false;
			}
			mBackgroundWasSwitchedOff = true;
		}
	}
}