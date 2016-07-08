using UnityEngine;
using System.Collections;

public class BalisticsAim : MonoBehaviour {

    public BalisticSolver solver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, 1 << 8))
        {
            solver.target = hitInfo.point;
        }
    }
}
