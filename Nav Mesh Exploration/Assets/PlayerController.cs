using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;
    public bool vector_render;
    public bool attributes_render;
    public bool attributes_visible;


	// Use this for initialization
	void Start () {
        //debug
        print("PlayerController initialization");
	}
	
	// Update is called once per frame
	void Update () {

        //listener to move to the raycast location
		/*
		 if (Input.GetMouseButtonDown(0))
        {
            print("PlayerController Button Down Registered");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Move the Agent
                agent.SetDestination(hit.point);
                print("PlayerController moving agent based on raycast");
            }

        }
        */


        //Test for Vector Flag to turn on vector line renderer
        if (vector_render = true) {

            //invoke the LineRenderer to render the direction vector for this agent
            LineRenderer lineRenderer = this.GetComponent<LineRenderer>();
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.forward * 3 + transform.position);
        }

        //make sure atributes visible is turned off
        if (attributes_render = false)
        {
            if (attributes_visible = true)
            {
                attributes_visible = false;
            }
        }

        //Test for Attribute Render Flag to turn on Canvas
        if (attributes_render = true)
        {
            if (attributes_visible = false){
                attributes_visible = true;
            }

            //make the canvas visible
            //Canvas myCanvas = this.GetComponent<LineRenderer>();

        }
	}

    void SetVectorRenderFalse()
    {
        //debug
        print("Setting Vector Render False");
        vector_render = false;
    }
}
