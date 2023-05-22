namespace RA1_Performance;

public class Functions
{
    public static bool IsValidNumber(string? valueFromUser)
    {
        if (int.TryParse(valueFromUser, out _) && !string.IsNullOrEmpty(valueFromUser) && !string.IsNullOrWhiteSpace(valueFromUser))
            return true;
    
        return false;
    }
    
    // Criando cache com valor digitado pelo usuário via console
     public static Dictionary<int, int> CreateCache(int cacheSizeFromUser)
     {
         var cache = new Dictionary<int, int>();
    
         for (var i = 0; i < cacheSizeFromUser; i++)
             cache.Add(i, -1);
    
         return cache;
     }

     public static Dictionary<int, int> DirectMapping(int cacheSize, List<int> memoryPosition)
    {
        var cache = CreateCache(cacheSize);
        string status;
        var hits = 0;
        var misses = 0;
        var counter = 0;
    
        foreach (var position in memoryPosition)
        {
            var cachePosition = position % cacheSize;
            var value = cache[cachePosition];
    
            if (value != position)
            {
                status = "Miss!";
                Console.WriteLine("Linha " + counter + " | " + "Posição de memória desejada: " + position);
                Console.WriteLine("Status: " + status);
                misses++;
            }
            else
            {
                status = "Hit!";
                Console.WriteLine("Linha " + counter + " | " + "Posição de memória desejada: " + position);
                Console.WriteLine("Status: " + status);
                hits++;
            }
            
            cache[cachePosition] = position;
    
            counter++;
            
            PrintCache(cache);
        }
    
        return cache;
    }
     
     public static void PrintCache(Dictionary<int, int> cache)
     {
         Console.WriteLine("Cache size: " + cache.Count);
         Console.WriteLine("| Cache position | Memory position |");
         Console.WriteLine("|--------------------------------  |");
    
         foreach (var value in cache)
             Console.WriteLine($"               {value.Key} | {value.Value}");
    
         Console.WriteLine("====================================");
     }

     public static void Informations(List<int> listNumbers, int hits, int misses)
     {
         Console.WriteLine("*------------------------------------*");
         Console.WriteLine("Memórias acessadas: " + listNumbers.Count);
         Console.WriteLine("Número de hits: " + hits);
         Console.WriteLine("Número de misses: " + misses);
         var totalAccess = listNumbers.Count;
         var hitRate = (hits * 100) / totalAccess;
         Console.WriteLine("Taxa de acerto (hits): " + hitRate + "%");
     }
}