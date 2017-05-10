using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerPlant : Building, ClickableBuilding{

	private string buildingType;

	// Use this for initialization
	void Start () {
		buildingType = "Nuclear Plant";

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		gameObject.tag = "Power Plant";
		base.OnGUI ();
		setText ();
	}

	public void  setText(){
		
		GameObject buildUI = getActiveUI ();
		if (buildUI != null) {
			Text labelText = buildUI.GetComponentInChildren<Text> ();
			labelText.text = buildingType;
		}

	}




}
