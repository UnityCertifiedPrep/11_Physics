using UnityEngine;
using System.Collections;

public class ProjectileExpiry : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
