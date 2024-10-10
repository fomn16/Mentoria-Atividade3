using Atividade2.Services;

// 1) Criar classe VogaisService dentro do arquivo Services
var vogaisService = new VogaisService();

Console.WriteLine("Favor fornecer um texto, para que seja feita a contagem de vogais: ");

// 2)   No serviço VogaisService, criar método "string? ObterTexto()"
//      Que lê a entrada do usuário e a retorna (mesmo que nula).
string? texto = vogaisService.ObterTexto();

// 3)   No serviço VogaisService, criar método "void PrintQuantidadeDeVogais(string texto)"
//      Que imprime na tela a quantidade de vogais presentes no texto passado
//      como parâmetro. caso o texto seja nulo, exibir mensagem de entrada inválida.

//      Observação: exercício pode ser feito com loop for/foreach ou utilizando métodos Linq
vogaisService.PrintQuantidadeDeVogais(texto);