using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    void Start()
    {
        // Variable initialization with n = 3
        int n = 3, ssum = 0, psum = 0;

        // Calculate ssum and psum
        for (int i = 1; i <= n; i++)
        {
            int temp1 = 0, temp2 = 1;

            // Calculate partial sum (temp1) and partial product (temp2)
            for (int j = 1; j <= i; j++)
            {
                temp1 += j;
                temp2 *= j;
            }

            // Update ssum and psum
            ssum += temp1;
            psum += temp2;
        }

        // Output the results using Debug.Log()
        Debug.Log("ssum: " + ssum);
        Debug.Log("psum: " + psum);
    }
}

