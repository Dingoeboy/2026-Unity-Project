using UnityEngine;

public class Operators : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 100;
    public int damage= 10;
    private int medpack = 5;

    //-----------------------------------------------------
    void Start()
    {
    

        // take of some damage from my health
        // I need to subtract

        health = 150;
        health = 250;

        health = health + 50;

        Debug.Log("Health; " + health);
        Debug.Log("Ouch!" + damage);
    }
    //-----------------------------------------------------



    //-----------------------------------------------------
    // Update is called once per frame
    void Update()
    {

    
    }
    //-----------------------------------------------------

}
