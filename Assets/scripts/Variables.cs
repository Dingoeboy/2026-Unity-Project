using UnityEngine;

public class Variables : MonoBehaviour
{
    public string playerName = "Gordon Freeman";
    public float countDownTimer = 30;
    public bool  gameOver = false;
    public int ammoValue = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(playerName);
        Debug.Log(countDownTimer);
        Debug.Log(ammoValue);
        Debug.Log(countDownTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
