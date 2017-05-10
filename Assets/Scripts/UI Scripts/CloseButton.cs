using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour {
	
	private string buildingIdentity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setBuildingIdentity(string str) {
		buildingIdentity = str;
	}


	//closes (destroys) the UI box
	//accesses object that orignially created UI, in order to call the close() method that destroys the UI
	public void destroyClose() {
		GameObject parentBuilding = GameObject.FindGameObjectWithTag (buildingIdentity);
		Building parentScript = parentBuilding.GetComponent<Building> ();
		parentScript.close ();
	}
}
