using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixTransform : MonoBehaviour
{
    void Start()
    {
        // �ʱ� �迭 �ʱ�ȭ
        int[,] matrix = new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

        // ��ȯ�� �迭 �ʱ�ȭ
        int[,] newMatrix = new int[3, 3];

        // ��ȯ ��Ģ ����
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // ���ο� �ε��� ���
                int new_i = 2 - j;
                int new_j = 2 - i;

                // ��ȯ�� �迭�� �� �Ҵ�
                newMatrix[new_i, new_j] = matrix[i, j];
            }
        }

        // ��� ���
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

