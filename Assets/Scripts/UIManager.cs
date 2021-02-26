using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text text;

    void Update()
    {
        text.text = "" + GameManager.instance.points;
    }
}
