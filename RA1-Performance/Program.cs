
Console.WriteLine("\n -- Conectividade em Sistemas Ciberfísicos- Mapeamento Direto -- \n");


Console.WriteLine("Digite o tamanho da cache: ");
var cacheSizeFromUser = Console.ReadLine();

while(!IsValidNumber(cacheSizeFromUser))
{
    Console.WriteLine("O valor não pode ser nulo, vazio ou conter letras.");
    Console.WriteLine("Digite o tamanho da cache: ");
    cacheSizeFromUser = Console.ReadLine();
}

var valueConvertedFromUser = int.Parse(cacheSizeFromUser);

var cache = CreateCache(valueConvertedFromUser);
PrintCache(cache);



// ======================================================
// Functions
bool IsValidNumber(string? valueFromUser)
{
    if (int.TryParse(valueFromUser, out _) && !string.IsNullOrEmpty(valueFromUser) && !string.IsNullOrWhiteSpace(valueFromUser))
        return true;

    return false;
}

// Criando cache com valor digitado pelo usuário via console
 Dictionary<int, int> CreateCache(int cacheSizeFromUser)
 {
     var cache = new Dictionary<int, int>();

     for (var i = 0; i < cacheSizeFromUser; i++)
         cache.Add(i, -1);

     return cache;
 }

void PrintCache(Dictionary<int, int> cache)
{
    Console.WriteLine("| Cache position | Memory position |");
    Console.WriteLine("|--------------------------------  |");
     
    foreach (var value in cache) 
        Console.WriteLine($"               {value.Key} | {value.Value}");
}

void DirectMapping(int cacheSize, List<int> memoryPosition)
{
    var cache = CreateCache(cacheSize);
    PrintCache(cache);

    foreach (var position in memoryPosition)
    {
        
    }
}

