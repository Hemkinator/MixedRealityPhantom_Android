using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Image1Toggle : MonoBehaviour, ITrackableEventHandler {
	private TrackableBehaviour mTrackableBehaviour;
	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{ 
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
			OnTrackingFound ();
		} else {
			OnTrackingLost ();
		}
	} 

	public void OnTrackingFound(){
		GameObject.Find ("Instantiator").GetComponent<InstantiationScript> ().image1tracked = true;
	}
	public void OnTrackingLost(){
		GameObject.Find ("Instantiator").GetComponent<InstantiationScript> ().image1tracked = false;
	}

}
