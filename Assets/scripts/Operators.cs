using UnityEngine;

public class Operators : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int currentHealth = 100;
    public int damageValue = 10;
    private int medPackValue = 5;

   
    void Start()
    {
    
        
        int bonusMultiplier = 2;
        int bonusValue = 10;
        int currentBonus = 0;


        Debug.Log("Health: " + currentHealth);
        Debug.Log("Damage value " + damageValue );
        Debug.Log("MedPack value: " + medPackValue);

        //take off damage from current health - subtraction
        //display value of health after damage
        currentHealth -= damageValue;
        Debug.Log("Health:" + currentHealth);

        //add medpack to our health
        //display value of health after medpack
        currentHealth += medPackValue;
        Debug.Log("Health: " + currentHealth);

        // calculate a bonus mechanic using multiplacation
        // add it to your health using addition
        currentHealth = 100;
        Debug.Log("current Health " + currentHealth);

        currentBonus = bonusValue * bonusMultiplier;
        currentHealth += currentBonus;

        Debug.Log("Bonus: " + bonusValue);
        Debug.Log("Bonus Multiplier: " + bonusMultiplier);
        Debug.Log("Current Bonus: " + currentBonus);
        Debug.Log("New Health:" + currentHealth);

        //Order of operations example
        int result = 10 + 5 * (20 / 4) - 3;
        Debug.Log("10 + 5 * (20 / 4) - 3 = " + result);


    }




    void Update()
    {

    
    }
   

}
