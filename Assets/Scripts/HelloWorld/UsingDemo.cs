//using 사용할때
/*
using UnityEngine;

public class UsingDemo : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World"); 
    }

    
    void Update()
    {
        
    }
}
*/

// using UnityEngine; 사용하지않을시

public class UsingDemo : UnityEngine.MonoBehaviour
{
    void Start()
    {
        UnityEngine.Debug.Log("Hello World");
    }


    void Update()
    {

    }

}