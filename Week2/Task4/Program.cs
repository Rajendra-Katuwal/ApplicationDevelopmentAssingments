int[] favNumbers = { 7, 14, 21, 28, 35 };

// sorting in acending order
Array.Sort(favNumbers);

// Reversing the array to get descending order
Array.Reverse(favNumbers);


// Printing each number in the array
Console.WriteLine("Favorite Numbers in Descending Order:");
int length = favNumbers.Length;
for (int i = 0; i < length; i++)
{
    Console.WriteLine(favNumbers[i]);
}


// Finding the index of a specific number
int index = Array.IndexOf(favNumbers, 21);
Console.WriteLine($"\nIndex of 21 in the array: {index}");