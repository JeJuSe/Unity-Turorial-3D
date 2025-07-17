using Unity.VisualScripting;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };
<<<<<<< Updated upstream
    
    void Start()
    {
        Debug.Log("ì •ë ¬ ì „ : " + string.Join(", ", array));

        Quick(array, 0, array.Length - 1);
        Debug.Log("ì •ë ¬ í›„ : " + string.Join(", ", array));
=======

    void Start()
    {
        Debug.Log("Á¤·Ä Àü : " + string.Join(", ", array));

        Quick(array, 0, array.Length - 1);
        Debug.Log("Á¤·Ä ÈÄ : " + string.Join(", ", array));
>>>>>>> Stashed changes
    }

    private void Quick(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
<<<<<<< Updated upstream
            
=======

>>>>>>> Stashed changes
            Quick(arr, left, pivot - 1);
            Quick(arr, pivot + 1, right);
        }
    }

<<<<<<< Updated upstream
    private int Partition(int[] arr, int left, int right) // í”¼ë´‡ì„ í™œìš©í•´ì„œ ë¶„í• 
=======
    private int Partition(int[] arr, int left, int right) // ÇÇº¿À» È°¿ëÇØ¼­ ºÐÇÒ
>>>>>>> Stashed changes
    {
        int pivot = arr[right];
        int index = left - 1;

        for (int i = left; i < right; i++)
        {
            if (arr[i] < pivot)
            {
                index++;

                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }

        int temp2 = arr[index + 1];
        arr[index + 1] = arr[right];
        arr[right] = temp2;

        return index + 1;
    }
}