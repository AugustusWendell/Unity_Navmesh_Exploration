using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourButton, m_YourSecondButton;
    //GameObject.Find("enemy");
    public GameObject controller;
    public GameObject target1;
    public GameObject target2;

    void Start()
    {
        Button btn = m_YourButton.GetComponent<Button>();
        Button btn2 = m_YourSecondButton.GetComponent<Button>();
        //Calls the TaskOnClick method when you click the Button
        //btn.onClick.AddListener(TaskOnClick);

        //m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });



        //set/populate controller and target objects
        controller = GameObject.Find("Controller");
        target1 = GameObject.Find("Target 1");
        target2 = GameObject.Find("Target 2");
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
        //GameObject.Find("Your_Name_Here").transform.position;
	}

    void UpdateTarget2()
    {
        //GameObject.Find("Your_Name_Here").transform.position;
    }

}
