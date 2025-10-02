# Check if a collection contains any negative numbers (⭐)

### Exercise description:

Implement the ContainsNegative method that checks whether a sequence of integers contains at least one negative number.

Keep performance in mind.


What you'll practice:

    Using foreach loops and IEnumerable

    Applying early return to improve efficiency

    Working with basic conditional logic

    Using the Any method from LINQ 


Example usage:

 
    var result = ContainsNegative(new List<int> { 5, 3, 0, -1, 7 }); // => true
    var result = ContainsNegative(new List<int> { 1, 2, 3, 4 });     // => false 



## Enumerable.Any Método

Definição

Namespace:
    System.Linq 

Assembly:
    System.Linq.dll

Determina se qualquer elemento de uma sequência existe ou atende a uma condição.

É possível usar o método Any do LINQ para verificar se existe algum número negativo em uma coleção de IEnumerable<int>. Basta importar o namespace System.Linq e utilizar a expressão numbers.Any(n => n < 0), onde n => n < 0 é uma função que retorna true para números negativos.

O método Any retorna true se pelo menos um elemento da coleção atender à condição especificada, e false caso contrário. Isso torna o código mais conciso e legível, eliminando a necessidade do foreach manual.

