using UnityEngine;

public class Loops : MonoBehaviour
{
    

    void Start()
    {
       for ( int myCount = 0;  myCount <=5; myCount++ )
       {
            Debug.Log("Loop iteration number: " + myCount);
       }
    }
}
