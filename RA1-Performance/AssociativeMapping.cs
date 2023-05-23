namespace RA1_Performance;

public class AssociativeMapping
{
    public static void Main() {
        var stack = new Stack<string>();
        
        stack.Push("Elemento 1");
        stack.Push("Elemento 2");
        stack.Push("Elemento 3");
        
        Console.WriteLine("Elemento do topo: " + stack.Peek());
        
        Console.WriteLine("Removendo elementos da pilha:");
        while (stack.Count > 0) 
        { 
            var element = stack.Pop(); 
            Console.WriteLine("Elemento removido: " + element);
        }
    }
}