namespace RA1_Performance;

public class DirectMapping
{
    private static string cacheSizeFromUser = "";
    private static int valueConvertedFromUser = 0;
    static int hits = 0;
    static int misses = 0;
    static int counter = 0;
    
    public static void Main()
    {
        Console.WriteLine("Digite o tamanho da cache: ");
        cacheSizeFromUser = Console.ReadLine();
        Console.WriteLine("");
        
        while(!Functions.IsValidNumber(cacheSizeFromUser))
        {
            Console.WriteLine("O valor não pode ser nulo, vazio ou conter letras.");
            Console.WriteLine("Digite o tamanho da cache: ");
            cacheSizeFromUser = Console.ReadLine();
        }
        
        valueConvertedFromUser = int.Parse(cacheSizeFromUser);
        
        Console.WriteLine("====================================");
        Console.WriteLine("Cache inicial: ");
        var cache = CreateCache(valueConvertedFromUser);
        PrintCache(cache);

        //var listNumbers = new List<int> {0, 1, 2, 3, 1, 4, 5, 6}; // TODO: remover hard code
        var listNumbers = new List<int> {33, 3, 11, 5};

        DirectMappingFunction(valueConvertedFromUser, listNumbers, counter);

        Informations(listNumbers, hits, misses);
        
        
        // Functions
        // Criando cache com valor digitado pelo usuário via console
        Dictionary<int, int> CreateCache(int cacheSizeFromUser)
         {
             var cache = new Dictionary<int, int>();
        
             for (var i = 0; i < cacheSizeFromUser; i++)
                 cache.Add(i, -1);
        
             return cache;
         }

         void DirectMappingFunction(int cacheSize, List<int> memoryPosition, int counter) 
         {
            var cache = CreateCache(cacheSize);
            string status;

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
         }

         void PrintCache(Dictionary<int, int> cache)
         {
             Console.WriteLine("Cache size: " + cache.Count);
             Console.WriteLine("| Cache position | Memory position |");
             Console.WriteLine("|--------------------------------  |");
        
             foreach (var value in cache)
                 Console.WriteLine($"               {value.Key} | {value.Value}");
        
             Console.WriteLine("====================================");
         }

         static void Informations(List<int> listNumbers, int hits, int misses)
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
}