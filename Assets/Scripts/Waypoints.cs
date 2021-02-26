using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int i = 0;
    public float speed;
    float WPradius = 0.1f;

    void Update()
    {
        if (Vector3.Distance(waypoints[i].transform.position, transform.position) < WPradius)
        {
            i = Random.Range(0, waypoints.Length);
            if (i >= waypoints.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[i].transform.position, Time.deltaTime * speed);
    }
}
