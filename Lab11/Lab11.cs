/*

 * Student ID : 1690701352

 * Name       : Lab11

 * Section    : 129b

 * No.        : N/A

 * Course     : GI113 Computer Programming (GI)

 */
using UnityEngine;

public class Array : MonoBehaviour
{
    //string name = "Rick";
    //public string[] names = {"Jim", "Bud", "Sam", "Tim", "Ark", "Fan" };
    [SerializeField]int[] scores = { 12, 7, 30, 4, 19, 25, 9, 18 };
    int sum;
    float average;
    int maximum;
    int minimum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
       for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("Scores " + (i + 1) + ": " + scores[i]);
        }

        sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        average = (float)sum / scores.Length;
        Debug.Log("Sum: " + sum);
        Debug.Log("Average: " + average);

        maximum = scores[0];
        minimum = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > maximum)
            {
                maximum = scores[i];
            }
            if (scores[i] < minimum)
            {
                minimum = scores[i];
            }
        }
        Debug.Log("Maximum: " + maximum);
        Debug.Log("Minimum: " + minimum);

        System.Array.Sort(scores);
        foreach (int n in scores)
        {
            Debug.Log("Sorted: " + n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
