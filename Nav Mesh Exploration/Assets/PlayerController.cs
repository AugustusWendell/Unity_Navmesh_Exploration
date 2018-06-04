using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /* comment out this call, have the SS_Agent_Controller call this of each agent
		if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Move the Agent
                agent.SetDestination(hit.point);
            }

        }
        */
	}
}
