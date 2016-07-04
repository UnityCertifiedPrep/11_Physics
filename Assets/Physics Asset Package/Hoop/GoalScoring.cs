using UnityEngine;
using System.Collections;

public class GoalScoring : MonoBehaviour
{
    public Highlighter highlighter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        print("Goal Scored!");
        if (highlighter)
        {
            highlighter.Highlight();
        }
    }
}