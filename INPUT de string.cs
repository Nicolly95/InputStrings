//Esse código valida a entrada de string.
//Ele utiliza o loop do-while para validar as condições: 
// a string deve ser correspondente às 3 opções de entradas pré estabelecidas.
//Utilizo o método .ToLower() para que o compilador ignore as diferenças entre maiúsculas 
// e minúsculas na hora de atribuir as entradas na variável. 
//Utiliza as condicionais IF-ELSE para retornar strings.


string? readResult;                            
string cargos = "Administrador | Gerente | Usuário".ToLower();

Console.WriteLine("Digite o seu cargo (Administrador, Gerente ou Usuário).");

do
{    
    readResult = Console.ReadLine(); 

    if (cargos.Contains(readResult)) 
    {                                      
        Console.WriteLine($"Seu valor de entrada ({readResult}) foi aceito.");  
    }
    else
    {        
        Console.WriteLine($"O cargo que você digitou, \"{readResult}\" não é válido. Insira o seu cargo (Administrador, Gerente ou Usuário).");
    }    

} while (!cargos.Contains(readResult));  
