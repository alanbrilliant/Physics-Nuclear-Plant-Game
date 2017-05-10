using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

	private bool mouseOver = false;


	public GameObject buildingUI;
	private GameObject activeBuildingUI;
	private CloseButton childClose;


	Shader shade;

	// Use this for initialization
	void Start () {
		
		shade = GetComponent<Renderer> ().material.shader;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver(){
		
		mouseOver = true;
		GetComponent<Renderer> ().material.shader = Shader.Find ("Self-Illumin/Outlined Diffuse");
	}

	void OnMouseExit(){
		mouseOver = false;
		GetComponent<Renderer> ().material.shader = Shader.Find ("Diffuse");
	}

	public bool getMouseOver() {
		return mouseOver;
	}

	public void OnGUI() {
		if (getMouseOver () == true) {

			if (Input.GetMouseButtonDown (0) == true) {
				if (activeBuildingUI == null){
					
					activeBuildingUI = Instantiate (buildingUI, new Vector3 (0, 0, 0), Quaternion.identity);
					childClose = activeBuildingUI.GetComponentInChildren<CloseButton>();

					childClose.setBuildingIdentity (tag);
					fixLabel ();
				}
			}
		}



	}

	public GameObject getActiveUI() {
		return activeBuildingUI;
	}

	private void fixLabel() {
		RectTransform panelLoc = activeBuildingUI.GetComponentsInChildren<RectTransform> ()[1];
		Vector3 mousePos = Input.mousePosition;
		Vector3 newPos;
		mousePos.x += 140;
		panelLoc.position = mousePos;
	}

	public void close() {
		Debug.Log ("fhajf");
		Destroy (activeBuildingUI);
	}


}
