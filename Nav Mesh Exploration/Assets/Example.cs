﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;


public class Example : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_Target1Button, m_Target2Button, m_AddAgentButton;
    public GameObject controller;
    public GameObject target1;
    public GameObject target2;
    public NavMeshAgent Agent1;
    public NavMeshAgent Agent2;
    public GameObject SSAgent;
    //private List AgentList;

    void Start()
    {
        //Button btn = m_Target1Button.GetComponent<Button>();
        //Button btn2 = m_Target2Button.GetComponent<Button>();

        //Calls the TaskOnClick method when you click the Button
        //btn.onClick.AddListener(TaskOnClick);

        //example listener assignment
        //m_Target1Button.onClick.AddListener(delegate { TaskWithParameters("Hello"); });

        m_Target1Button.onClick.AddListener(delegate { UpdateTarget1(); });
        m_Target2Button.onClick.AddListener(delegate { UpdateTarget2(); });
        m_AddAgentButton.onClick.AddListener(delegate { AddAgent(); });


        //set/populate controller and target objects
        controller = GameObject.Find("Controller");
        target1 = GameObject.Find("Target 1");
        target2 = GameObject.Find("Target 2");

        List<NavMeshAgent> AgentList = new List<NavMeshAgent>();
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button is clicked
        Debug.Log(message);
    }


	void UpdateTarget1()
	{
        //set all agents to go to target 1
        Agent1.SetDestination(target1.transform.position);
        Agent2.SetDestination(target1.transform.position);
	}

    void AddAgent()
    {
        GameObject newAgent = (GameObject)Instantiate(SSAgent, transform.position, transform.rotation);
        //AgentList.add(newAgent);
    }


    void UpdateTarget2()
    {
        //set all agents to go to target 2
        Agent1.SetDestination(target2.transform.position);
        Agent2.SetDestination(target2.transform.position);
    }

}
