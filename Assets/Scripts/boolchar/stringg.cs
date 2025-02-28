using UnityEngine;

public class stringg : MonoBehaviour
{
    void Start()
    {
        string message = "문자열보간법";

        Debug.Log("Message : " + message); //[1]
        Debug.Log($"Message: {message}"); //[2] 문자열보간법

        //string.Format
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요");
        // 각각 문자열이 0번과 1번에 들어감
        Debug.Log(msg);
    }
    
    void Update()
    {
        
    }
}
