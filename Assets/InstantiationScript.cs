using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        Calibrate();
        float dist1 = Vector3.Distance(image1.transform.position, image2.transform.position);
        float dist2 = Vector3.Distance(image3.transform.position, image4.transform.position);
        dist2 = dist2 / 0.01f;
        dist1 = dist1 / 0.01f;
        GameObject.Find("Text1").GetComponent<Text>().text = "Distance between image 1 and image 2: " + dist1 + "cm";
        GameObject.Find("Text2").GetComponent<Text>().text = "Distance between image 3 and image 4: " + dist2 + "cm";
    }

    public void Calibrate()
    {
        Vector3 pos1 = Vector3.Lerp(image1.transform.position, image2.transform.position, 0.5f);
        Vector3 pos2 = Vector3.Lerp(image3.transform.position, image4.transform.position, 0.5f);
        Vector3 finalpos = Vector3.Lerp(pos1, pos2, 0.5f);
        double finalx = Math.Round(finalpos.x, 2);
        double finaly = Math.Round(finalpos.y, 2);
        double finalz = Math.Round(finalpos.z, 2);
        Testcube.transform.position = new Vector3((float)finalx, (float)finaly, (float)finalz);

    }

}
