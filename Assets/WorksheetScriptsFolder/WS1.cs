using UnityEngine;


public class WS1_Q1 : MonoBehaviour
{
    string name = "AJ";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Q1
        Welcome_Q1();
        
        PrintObjectName();
        PrintLogs();
    }
    //Write a void method Welcome that prints
    // "Welcome to class" and show how to call it.

    void Update()
    {
        //Q2
        message();
    }
    void Welcome_Q1()
    {
        //Q3
        Debug.Log("Welcome to Class " + name);
    }
    //Q4 Give Welcome a default parameter so it works with or without a name.
    void Welcome_Q4(string name = "AJ")
    {
        Debug.Log("Welcome to Class " + name);
    }
    void message()
    {
        Debug.Log("Print message every frame");
    }
    //Q5 Create a method that prints the object’s name
    void PrintObjectName()
    {
        Debug.Log("The object name is " + gameObject.name);
    }

    //Q6 Create a method that prints a normal log, a warning and an error
    void PrintLogs()
    {
        Debug.Log("This is a normal message");
        Debug.LogWarning("This is a warning message!");
        Debug.LogError("This is an error message!!!");
    }
}
