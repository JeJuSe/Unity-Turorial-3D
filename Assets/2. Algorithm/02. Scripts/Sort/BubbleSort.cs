<<<<<<< Updated upstream
ï»¿using UnityEngine;
=======
using UnityEngine;
>>>>>>> Stashed changes

public class BubbleSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };
<<<<<<< Updated upstream
    
    void Start()
    {
        Debug.Log("ì •ë ¬ ì „ : " + string.Join(", ", array));

        Bubble(array);
        Debug.Log("ì •ë ¬ í›„ : " + string.Join(", ", array));
=======

    void Start()
    {
        Debug.Log("Á¤·Ä Àü : " + string.Join(", ", array));

        Bubble(array);
        Debug.Log("Á¤·Ä ÈÄ : " + string.Join(", ", array));
>>>>>>> Stashed changes
    }

    private void Bubble(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}