using UnityEngine;

public class Components9a1 : MonoBehaviour
{
    public string aName = "Doctor";
    public int aNumber = 42;

    private string secretWord = "Melon";

    private Component9a2 referencetoscript2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("The name is " + aName + " and the number is " + aNumber);
        Debug.Log($"The name is {aName} and the number is {aNumber}"); // string interpolation)
        Debug.Log($"The secret word is {secretWord}");
        
        referencetoscript2 = GetComponent<Component9a2>();

        Debug.Log("The place is " + referencetoscript2.aPlace);
        referencetoscript2.DisplayLocation();
        displaySecretWord();
    }
    void displaySecretWord()
    {
        Debug.Log($"The secret word is {secretWord} 'so please keep it secret");

    }// end of displaqy secretword function

}
