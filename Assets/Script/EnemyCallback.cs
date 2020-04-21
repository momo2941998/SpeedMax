using UnityEngine;
using System.Collections;

public class EnemyCallback : MonoBehaviour {

	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target.transform.position.z >= (this.transform.position.z + 20)) {
		     Vector3 np = this.transform.position;
		     np.x = 0;
		     np += new Vector3(Random.Range(-4.5f, 4.5f), 0, Random.Range(40, 60));
		     this.transform.position = np;
		}
	}
}
