using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ssumAndPsum : MonoBehaviour
{
    public int n;
    int ssum = 0;
    int psum = 0;
    void Start()
    {
        if (n == 0)
        {
            Debug.Log("n값이 0입니다.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                int tempA = 0;
                int tempB = 1;

                for (int j = 1; j <= i; j++)
                {
                    tempA += j;
                    tempB *= j;
                }

                ssum += tempA;
                psum += tempB;
            }

            Debug.Log("ssum : " + ssum);
            Debug.Log("psum : " + psum);
        }
        
    }

}
