using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixTransform : MonoBehaviour
{
    void Start()
    {
        // 초기 배열 초기화
        int[,] matrix = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

        // 변환된 배열 초기화
        int[,] newMatrix = new int[3, 3];

        // 변환 규칙 적용
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // 새로운 인덱스 계산
                int new_i = 2 - j;
                int new_j = 2 - i;

                // 변환된 배열에 값 할당
                newMatrix[new_i, new_j] = matrix[i, j];
            }
        }

        // 결과 출력
        for (int i = 0; i < 3; i++)
        {
            string row = "";
            for (int j = 0; j < 3; j++)
            {
                row += newMatrix[i, j] + " ";
            }
            Debug.Log(row);
        }
    }
}

