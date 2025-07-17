using UnityEngine;

public class InsertionSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };
<<<<<<< Updated upstream
    
    void Start()
    {
        Debug.Log("ì •ë ¬ ì „ : " + string.Join(", ", array));

        Insertion(array);
        Debug.Log("ì •ë ¬ í›„ : " + string.Join(", ", array));
=======

    void Start()
    {
        Debug.Log("Á¤·Ä Àü : " + string.Join(", ", array));

        Insertion(array);
        Debug.Log("Á¤·Ä ÈÄ : " + string.Join(", ", array));
>>>>>>> Stashed changes
    }

    private void Insertion(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}