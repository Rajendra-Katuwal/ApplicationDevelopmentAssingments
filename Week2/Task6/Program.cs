// List Example
List <string> favFruits = new List <string> { "Apple", "Banana", "Cherry" };
favFruits.Add("Tomato");
favFruits.Remove("Banana");

foreach (var fruit in favFruits)
{
    Console.WriteLine(fruit);
}



// Dictionary Example
Dictionary <int, string> fruits = new();
fruits.Add(1, "Apple");
fruits.Add(2, "Banana");
fruits.Add(3, "Cherry");

foreach (var kvp in fruits)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}