using UnityEngine;
using System.Collections;

public class StreetCallback : MonoBehaviour {
	public GameObject target ;
	// Use this for initialization
	void Start () {
	target = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (target.transform.position.z >= (this.transform.position.z + 20)) {
		     this.transform.position += new Vector3(0, 0, 60);
		}
	}
}
