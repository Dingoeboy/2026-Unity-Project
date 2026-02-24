using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public bool hasDungeonKey = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      if (hasDungeonKey)
        {
            Debug.Log("You can enter the dungeon");
        }
      else
        {
            Debug.Log("Find the key first");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
