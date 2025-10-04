using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static Dictionary<char, int> CountCharacterFrequencies(
            string input)
        {
            //your code goes here
            Dictionary<char, int> characterFrequencies = new Dictionary<char, int>();
            
            foreach (char letter in input){
                if(characterFrequencies.ContainsKey(letter)){
                    characterFrequencies[letter]++;
                }else{
                    characterFrequencies[letter] = 1;
                }
            }
            return characterFrequencies;
        }
    }
}

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static Dictionary<char, int> CountCharacterFrequencies(
            string input)
        {
           return input
                .GroupBy(character => character)
                .ToDictionary(group => group.Key, group => group.Count());
        }
    }
}

/*
Lógica passo a passo

    input.GroupBy(c => c): Agrupa todos os caracteres iguais da string. Cada grupo tem uma chave (Key) que é o caractere, e uma coleção de ocorrências desse caractere.

    .ToDictionary(g => g.Key, g => g.Count()): Para cada grupo, cria uma entrada no dicionário onde:

        a chave é o caractere (g.Key)

        o valor é a quantidade de vezes que esse caractere aparece (g.Count())

Exemplo prático

Se input = "banana", o resultado será:

    'b' → 1

    'a' → 3

    'n' → 2

Ou seja, cada caractere vira uma chave no dicionário, e o valor é o número de vezes que ele aparece na string.

Usando apenas GroupBy

Se você fizer:

csharp
var grupos = input.GroupBy(c => c);

    grupos será uma coleção de grupos (IGrouping<char, char>), onde cada grupo representa um caractere distinto da string.

    Cada grupo tem uma propriedade .Key (o caractere) e contém todos os elementos iguais a esse caractere.

Exemplo prático

Se input = "banana", então:

    O primeiro grupo tem .Key = 'b' e contém: ['b']

    O segundo grupo tem .Key = 'a' e contém: ['a', 'a', 'a']

    O terceiro grupo tem .Key = 'n' e contém: ['n', 'n']

Você pode percorrer assim:

csharp
foreach (var grupo in grupos)
{
    Console.WriteLine($"Caractere: {grupo.Key}");
    foreach (var letra in grupo)
    {
        Console.WriteLine($"  {letra}");
    }
}

Isso vai mostrar cada grupo e os elementos dentro dele. Para contar quantos elementos tem em cada grupo, basta usar grupo.Count().
Resumindo

    GroupBy agrupa os elementos iguais, mas ainda não transforma em dicionário.

    Cada grupo tem uma chave (Key) e uma coleção dos elementos agrupados.

    Para transformar em dicionário, você usa ToDictionary(g => g.Key, g => g.Count())

Veja como funciona o GroupBy na prática, antes de transformar em dicionário:

csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "banana";
        var grupos = input.GroupBy(c => c);

        foreach (var grupo in grupos)
        {
            Console.WriteLine($"Caractere: {grupo.Key}");
            foreach (var letra in grupo)
            {
                Console.WriteLine($"  {letra}");
            }
        }
    }
}

O que acontece nesse código?

    input.GroupBy(c => c) agrupa todos os caracteres iguais.

    Cada grupo tem uma chave (Key) que é o caractere, e uma coleção dos elementos agrupados.

    O foreach externo percorre cada grupo (por exemplo, grupo da letra 'a').

    O foreach interno percorre cada ocorrência desse caractere.

Saída para "banana"

text
Caractere: b
  b
Caractere: a
  a
  a
  a
Caractere: n
  n
  n

Assim, você vê claramente como o GroupBy separa os elementos em grupos antes de transformar em dicionário. Cada grupo contém todas as ocorrências do caractere correspondente.

/*