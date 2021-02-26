using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    
    public void GoToLose()
    {
        SceneManager.LoadScene("Lose Scene");
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
