using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgoritmoOrdenador : MonoBehaviour
{
    public static void OrdenarListaSimple(ListaSimple.SimpleLinkedList<int> list)
    {
        int length = list.GetLength();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = list.GetNodeAtPosition(i);
        }

        InsertionSort(array);

        for (int i = 0; i < length; i++)
        {
            list.ModifyValueAtPosition(array[i], i);
        }
    }

    public static void InsertionSort(int[] numbers)
    {
        int tmp;
        for (int i = 1; i < numbers.Length; i = i + 1)
        {
            tmp = numbers[i];
            int j = i - 1;
            while (j >= 0 && numbers[j] > tmp)
            {
                numbers[j + 1] = numbers[j];
                j = j - 1;
            }
            numbers[j + 1] = tmp;
        }
    }
}
//Al haber un for con un while dentro es un Tiempo Asintotico de O(n^2) 