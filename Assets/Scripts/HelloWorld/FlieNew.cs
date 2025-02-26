//[1] 네임스페이스 선언부 
using UnityEngine; // 현재 (FileNew) 클래스파일에서 UnityEngine 네임스페이스를 사용하겠다 선언

//[2] 클레스 선언부 : 클래스의 이름은 FileNew
public class FlieNew : MonoBehaviour
{
    //[3] start 메서드선언 : 프로그램을 시작할때 1번만 실행
    void Start()
    {
        //[5] 명령문 콘솔창 출력문
        Debug.Log("Hello World");
    }

    //[4] update 메서드선언 : 프로그램 시작후에 매 프레임마다 실행(무한히 실행)
    void Update()
    {
        
    }
}
