﻿using System;
using System.Collections.Generic;
using System.Linq;

class MergeSortAlgorithm
{
    public static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middleIndex = (array.Length) / 2;
        int[] left = new int[middleIndex];
        int[] right = new int[array.Length - middleIndex];

        Array.Copy(array, left, middleIndex);
        Array.Copy(array, middleIndex, right, 0, right.Length);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    public static int[] Merge(int[] left, int[] right)
    {

        List<int> leftList = left.OfType<int>().ToList();
        List<int> rightList = right.OfType<int>().ToList();
        List<int> resultList = new List<int>();

        while (leftList.Count > 0 || rightList.Count > 0)
        {
            if (leftList.Count > 0 && rightList.Count > 0)
            {
                if (leftList[0] <= rightList[0])
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            else if (leftList.Count > 0)
            {
                resultList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }

            else if (rightList.Count > 0)
            {
                resultList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
        }

        int[] result = resultList.ToArray();
        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i]=int.Parse(Console.ReadLine());
        }

        array = MergeSort(array);

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine(array[index]);
        }
    }
}
