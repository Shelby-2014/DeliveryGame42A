using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("1st message to show");
       PrintingMessage();
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("This will repeat"); 
    }

    void PrintingMessage()
    {
        Debug.Log("Message from a method");
    }
}
