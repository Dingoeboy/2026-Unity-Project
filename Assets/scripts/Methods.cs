using UnityEngine;

public class Methods : MonoBehaviour
{
    public int myHealth = 100;
    public int myDamage = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    { DisplayHealth();
        
    }
    public int subtract(int number1, int number2)
        { return number1 - number2; }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayHealth()
    {
        Debug.Log(myHealth);
    }
}
     