using UnityEngine;

public class LogDemo : MonoBehaviour
{
    void Start()
    {
        Debug.Log("hello world");

        UnityEngine.Debug.Log("Aris Love");

        Debug.Log("결과는: " + 5);
        Debug.Log("결과는: " + (5 + 10));
        Debug.Log("결과는: " + 5 + 10);
    }


    void Update()
    {
        
    }
}
