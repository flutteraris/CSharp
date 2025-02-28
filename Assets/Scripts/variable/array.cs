using UnityEngine;

public class array : MonoBehaviour
{
    void Start()
    {
        int[] a = new int[5];
        a[0] = 5;
        a[1] = 3;
        a[2] = 6;
        a[3] = 8;
        a[4] = 9;

        int min = a[0];

        for(int k = 1; k<5; k++)
        {

            if (a[k] < min)
            {
                min = a[k];
            }
        }

        Debug.Log("최솟값은 : " + min + "입니다");
    }

    
    void Update()
    {
        
    }
}
