using UnityEngine;

public class stringg : MonoBehaviour
{
    void Start()
    {
        string message = "���ڿ�������";

        Debug.Log("Message : " + message); //[1]
        Debug.Log($"Message: {message}"); //[2] ���ڿ�������

        //string.Format
        string msg = string.Format("{0}��, {1}", "ȫ�浿", "�ȳ��ϼ���");
        // ���� ���ڿ��� 0���� 1���� ��
        Debug.Log(msg);
    }
    
    void Update()
    {
        
    }
}
