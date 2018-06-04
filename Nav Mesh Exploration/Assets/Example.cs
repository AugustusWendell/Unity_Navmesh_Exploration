using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourButton, m_YourSecondButton;

    void Start()
    {
        Button btn = m_YourButton.GetComponent<Button>();
        Button btn2 = m_YourSecondButton.GetComponent<Button>();
        //Calls the TaskOnClick method when you click the Button
        btn.onClick.AddListener(TaskOnClick);

        m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
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
}
