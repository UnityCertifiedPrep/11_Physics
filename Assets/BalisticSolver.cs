using UnityEngine;
using System.Collections;

public class BalisticSolver : MonoBehaviour {

    public Vector3 target;
    public float launchVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 launchVelocity = SolveBalistics();
        Debug.DrawLine(transform.position, transform.position + launchVelocity * 10);
	}

    Vector3 SolveBalistics()
    {
        var g = Physics.gravity.magnitude;
        var v = launchVelocity;
        var x = Vector3.ProjectOnPlane(target, Vector3.up).magnitude;
        var y = Vector3.Project(target, Vector3.up).magnitude;

        var theta = Mathf.Atan((v*v - Mathf.Sqrt(Mathf.Pow(v, 4) - g*(g*x*x + 2*y*v*v))) / (g*x));
        return Vector3.RotateTowards(target, Vector3.up, Mathf.Rad2Deg * theta, Mathf.Infinity);
    }
}
