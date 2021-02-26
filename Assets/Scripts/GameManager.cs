using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float points = 0;
    public static GameManager instance;
    public bool isStart = false;

    void Awake()
    {
        if (instance == null)
            instance = this;

        Time.timeScale = 0;
    }

    void Update()
    {
        if(isStart == false)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1;
                isStart = true;
            }
    }
}
