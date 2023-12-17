// * Использовать рекурсию, не использовать циклы.


//   int[] array = new int[5];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = new Random().Next(1, 10);
//             Console.Write(array[i] + " ");
//         }

// int temp;
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
    
// }
 // Console.Write("\nПеревернутый массив: ");
// foreach (int number in array)
// {
//     Console.Write(number + " ");
// }
   
int[] array = new int[5];
 void generateArray(int index, int[] arr)
 {
    arr[index] = new Random().Next(1, 10);
    if (index == arr.Length - 1)
        return;
    else generateArray(index + 1, arr);
}
 generateArray(0, array);
foreach (int number in array)
{
    Console.Write(number + " ");
 }

Console.WriteLine("");

int temp;
void getRecurs(int i, int[] arr)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
    if(i < arr.Length/2 - 1)
    getRecurs (i+1,arr);
    else return;

}

getRecurs(0,array);
foreach (int number in array)
{
    Console.Write(number + " ");
}