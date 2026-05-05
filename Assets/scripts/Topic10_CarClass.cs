using UnityEngine;

public class Topic10_CarClass : Topic10_VechicleClass
{
    public string childMessage = "Hello from Child!";

    public string carModel;
    void Start()
    {
        childMessage = "Car Class";
        carModel = "vw Polo";

        vechicleCost = 4000;
        parentMessage = "Vechicle class";

        Debug.Log("Child message from child: " + childMessage);
        Debug.Log("Parent message from parent: " + parentMessage);
        Debug.Log("Vechicle cost from parent: " + vechicleCost);
        Debug.Log("Car model from child: " + carModel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
