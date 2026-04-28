using UnityEngine;

public class Component9b1 : MonoBehaviour
{
    public string secondObjectName = "second Empty";

    private int secondSecretNumber = 5;
   
    void Start()
    {
        GameObject otherObject_9a = GameObject.Find("Topic 9a - Components");

        if (otherObject_9a == null)
        {

            Debug.LogError("Object could not be found");
        }

        else
        {
            Debug.Log("Object was found");

        }


    }

   
   
}
