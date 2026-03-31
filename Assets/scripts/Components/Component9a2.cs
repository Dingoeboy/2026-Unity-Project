using UnityEngine;

public class Component9a2 : MonoBehaviour
{
    public string aPlace = "Gallifrey";

    private Vector3 secretLocation = new Vector3(42f,13f,3.14f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisplayLocation();
    }//end of start function

    // Update is called once per frame
    public void DisplayLocation()
    {
        Debug.Log($"{aPlace}'s location is {secretLocation}");
    }// end of display location function
}
