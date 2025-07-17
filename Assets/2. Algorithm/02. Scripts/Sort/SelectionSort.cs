using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };

    void Start()
    {
<<<<<<< Updated upstream
        Debug.Log("ì •ë ¬ ì „ : " + string.Join(", ", array));

        Selection(array);
        Debug.Log("ì •ë ¬ í›„ : " + string.Join(", ", array));
    }
    
    private void Selection(int[] arr)
    {
        int n = arr.Length;
        
        // ì¸ë±ìŠ¤ ê°’ ì„ íƒ
        for (int i = 0; i < n - 1; i++) // i : ì„ íƒí•œ ì¸ë±ìŠ¤
        {
            int minIdx = i;
            
            // ë’¤ì— ìžˆëŠ” ê°’ë“¤ê³¼ ë¹„êµ
            for (int j = i + 1; j < n; j++) // j : ë¹„êµí•  ì¸ë±ìŠ¤
=======
        Debug.Log("Á¤·Ä Àü : " + string.Join(", ", array));

        Selection(array);
        Debug.Log("Á¤·Ä ÈÄ : " + string.Join(", ", array));
    }

    private void Selection(int[] arr)
    {
        int n = arr.Length;

        // ÀÎµ¦½º °ª ¼±ÅÃ
        for (int i = 0; i < n - 1; i++) // i : ¼±ÅÃÇÑ ÀÎµ¦½º
        {
            int minIdx = i;

            // µÚ¿¡ ÀÖ´Â °ªµé°ú ºñ±³
            for (int j = i + 1; j < n; j++) // j : ºñ±³ÇÒ ÀÎµ¦½º
>>>>>>> Stashed changes
            {
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            }

            int temp = arr[i];
            arr[i] = arr[minIdx];
            arr[minIdx] = temp;
        }
    }
}