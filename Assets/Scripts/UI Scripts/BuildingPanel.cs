using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPanel : MonoBehaviour {

	private bool draggable;


	RectTransform transf;
	// Use this for initialization
	void Start () {
		transf = GetComponent<RectTransform> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void Drag(){
		/*draggable = true;


		Debug.Log ("huiui");
		while (draggable == true) {
			if (Input.GetMouseButtonDown (0) == true) {
				Vector3 mousePos = Input.mousePosition;
				Vector3 temp = transf.position + (mousePos - transf.position);
				transf.position = temp;
			}
		}


*/
	}
}
