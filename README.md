# Proposta de requisitos
Implemente um document assembler simples com as seguintes características:

![image](https://github.com/user-attachments/assets/88ebd38c-2461-4399-8e88-9be76dd4523d)

1- Cada documento representará uma estrutura de árvore (figura acima) onde
as folhas terão um campo de texto que poderão ser printados na execução.

2- Cada nó da árvore poderá ser printado de diversas formas (deverá ser
extensível) sendo que concretamente a forma mais simples será mostrar no
console os valores das folhas em qualquer tipo de percurso da árvore.

3- Deverá ser estabelecido um mecanismo de monitoramento da execução que
não influirá no fluxo de execução e só vai oferecer informações sobre o
componente que está sendo executando. Estas informações poderão ser: tipo
de componente, profundidade do componente na arvore, horário, entre
outras. Poderão ser utilizados vários tipos de monitoramento para cada
componente.

# Solução proposta

Organização atual do repositório:
![image](https://github.com/user-attachments/assets/78936d4d-88a7-4a79-b1cf-ab8a9bb29875)

Há um assembly de teste que monta uma árvore, popula seus nós, cria monitores e printers, e executa a linha de comando.

Exemplo de execução:

    [Início]
      	Horário de execução: 30/06/2025 12:18:36
      	Profundidade: 1
      	Tipo do nó DocumentAssembler.Modelos.Node
      	Texto do nó: Não definido
      	Horario Criação: 30/06/2025 12:18:36
      	Tipo de printer DocumentAssembler.Printers.PrinterConsoleHorario
      Profundidade: 1, Tipo do nó DocumentAssembler.Modelos.Node, Horario Criação: 30/06/2025 12:18:36, Horário de execução: 30/06/2025 12:18:36
    [Fim]
