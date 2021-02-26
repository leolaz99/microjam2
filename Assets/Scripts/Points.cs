using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour
{
    bool isEnter = false;
    [SerializeField] GameObject bar;
    [SerializeField] float points;
    [SerializeField] float stopTime;
    Waypoints waypoints;
    float originalSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isEnter = false;    
    }

    IEnumerator BlockBar()
    {
        waypoints.speed = 0;
        yield return new WaitForSeconds(stopTime);
        waypoints.speed = originalSpeed;
    }


    void Awake()
    {
        waypoints = FindObjectOfType<Waypoints>();
    }

    void Update()
    {
        if (isEnter && GameManager.instance.isStart == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && waypoints.speed != 0)
            {
                originalSpeed = waypoints.speed;
                StartCoroutine(BlockBar());
                GameManager.instance.points += points;
            }
        }
    }
}
