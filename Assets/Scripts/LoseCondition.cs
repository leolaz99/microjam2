using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    bool isEnter = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isEnter = false;
    }

    void Update()
    {
        if (isEnter)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneLoader.instance.GoToLose();
            }
        }
    }
}
