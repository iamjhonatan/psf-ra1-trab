
using RA1_Performance;

string? typeOfMapping;

Console.WriteLine("\n -- Conectividade em Sistemas Ciberfísicos- Mapeamento Direto -- \n");
Thread.Sleep(2000);
Console.WriteLine("Digite o tipo de mapeamento: \n");
Console.WriteLine("1- Mapeamento Direto \n2- Mapeamento Associativo \n3- Mapeamento Associativo por Conjunto");

typeOfMapping = Console.ReadLine();
Console.WriteLine("");

if (Functions.IsValidNumber(typeOfMapping))
{
    var typeConvertedFromUser = int.Parse(typeOfMapping);
    switch (typeConvertedFromUser)
    {
        case 1:
            DirectMapping.Main();
            break;
        case 2:
            LRUCache.Main();
            break;
        case 3:
            //AssociativeMappingBySet.Main();
            break;
    }
}