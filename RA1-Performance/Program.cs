
using RA1_Performance;

Console.WriteLine("\n -- Conectividade em Sistemas Ciberfísicos- Mapeamento Direto -- \n");

var hits = 0;
var misses = 0;
var counter = 0;

Console.WriteLine("Digite o tamanho da cache: ");
var cacheSizeFromUser = Console.ReadLine();
Console.WriteLine("");

while(!Functions.IsValidNumber(cacheSizeFromUser))
{
    Console.WriteLine("O valor não pode ser nulo, vazio ou conter letras.");
    Console.WriteLine("Digite o tamanho da cache: ");
    cacheSizeFromUser = Console.ReadLine();
}

var valueConvertedFromUser = int.Parse(cacheSizeFromUser);

Console.WriteLine("====================================");
Console.WriteLine("Cache inicial: ");
var cache = Functions.CreateCache(valueConvertedFromUser);
Functions.PrintCache(cache);

//var listNumbers = new List<int> {0, 1, 2, 3, 1, 4, 5, 6}; // TODO: remover hard code
var listNumbers = new List<int> {33, 3, 11, 5};

Functions.DirectMapping(valueConvertedFromUser, listNumbers);


Functions.Informations(listNumbers, hits, misses);