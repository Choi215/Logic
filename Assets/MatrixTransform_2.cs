using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixTransform_2 : MonoBehaviour
{
    void Start()
    {
        // 초기 배열 초기화
        int[,] matrix = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

        // 배열의 중앙 가로선 기준으로 위 아래로 뒤집기
        int n = matrix.GetLength(0);
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[n - 1 - i, j];
                matrix[n - 1 - i, j] = temp;
            }
        }

        // 결과 출력
        for (int i = 0; i < 3; i++)
        {
            string row = "";
            for (int j = 0; j < 3; j++)
            {
                row += matrix[i, j] + " ";
            }
            Debug.Log(row);
        }
    }
}
