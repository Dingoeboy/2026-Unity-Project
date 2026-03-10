using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class DataStructures : MonoBehaviour   
{
    List<string> playerNames = new List<string>();

    void Start()

    {
        playerNames.Add("Picard");
        playerNames.Add("Kirk");
        playerNames.Add("Janeway");
        playerNames.Add("Archer");
        playerNames.Add("Sisko");



        // iterate through the list
        // becareful with the for loop conditions
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log("My favorite captain is: : " + playerNames[i]);

        }
            
            
    }

     
}