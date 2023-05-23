namespace RA1_Performance;

// Mapeamento Associativo por Conjunto
public class LRUCache
{
    public static void Main()
    {
        Console.Write("Digite o tamanho do conjunto: ");
        int setSize = int.Parse(Console.ReadLine());

        // Criando o conjunto
        Dictionary<int, string> set = new Dictionary<int, string>();

        while (true)
        {
            // Exibindo o conjunto atual
            Console.WriteLine("\nConjunto atual:");
            foreach (var item in set)
                Console.WriteLine($"{item.Key}: {item.Value}");

            // Menu de opções
            Console.WriteLine("\nEscolha a técnica de substituição:");
            Console.WriteLine("1. LRU (Least Recently Used)");
            Console.WriteLine("2. LFU (Least Frequently Used)");
            Console.WriteLine("3. FIFO (First In, First Out)");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: // LRU
                    Console.Write("Digite a chave: ");
                    int LRUKey = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor: ");
                    string LRUValue = Console.ReadLine();

                    if (set.ContainsKey(LRUKey))
                        set.Remove(LRUKey);
                    
                    else if (set.Count >= setSize)
                    {
                        int firstKey = -1;
                        foreach (var item in set)
                        {
                            firstKey = item.Key;
                            break;
                        }
                        set.Remove(firstKey);
                    }
                    set.Add(LRUKey, LRUValue);
                    break;

                case 2: // LFU
                    Console.Write("Digite a chave: ");
                    int LFUKey = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor: ");
                    string LFUValue = Console.ReadLine();

                    if (set.ContainsKey(LFUKey))
                        set[LFUKey] = LFUValue;
                    
                    else if (set.Count >= setSize)
                    {
                        int minFrequency = int.MaxValue;
                        int keyRemove = -1;
                        foreach (var item in set)
                        {
                            if (item.Value == LFUValue)
                            {
                                if (item.Key < keyRemove)
                                    keyRemove = item.Key;
                            }
                            if (item.Value != LFUValue && item.Key < keyRemove)
                            {
                                keyRemove = item.Key;
                                minFrequency = item.Value.Length;
                            }
                        }
                        if (keyRemove != -1)
                            set.Remove(keyRemove);
                    }
                    else
                        set.Add(LFUKey, LFUValue);
                    
                    break;

                case 3: // FIFO
                    Console.Write("Digite a chave: ");
                    int FIFOKey = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor: ");
                    string FIFOValue = Console.ReadLine();

                    if (set.ContainsKey(FIFOKey))
                        set[FIFOKey] = FIFOValue;
                    
                    else if (set.Count >= setSize)
                    {
                        int firstKey = -1;
                        foreach (var item in set)
                        {
                            firstKey = item.Key;
                            break;
                        }
                        set.Remove(firstKey);
                    }
                    else
                        set.Add(FIFOKey, FIFOValue);
                    
                    break;

                case 0: // Sair
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
