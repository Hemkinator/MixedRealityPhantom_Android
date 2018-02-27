using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationScript : MonoBehaviour {
	public bool image1tracked = false;
	public bool image2tracked = false;
	public bool image3tracked = false;
	public bool image4tracked = false;
	public GameObject image1;
	public GameObject image2;
	public GameObject image3;
	public GameObject image4;
	public Transform Testcube;
	private bool complete = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos1 = Vector3.Lerp (image1.transform.position, image2.transform.position, 0.5f);
		Vector3 pos2 = Vector3.Lerp (image3.transform.position, image4.transform.position, 0.5f);
		Vector3 finalpos = Vector3.Lerp (pos1, pos2, 0.5f);
        Testcube.transform.position = finalpos;
	}

}
