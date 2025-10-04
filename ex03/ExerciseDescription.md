# Count character frequencies in a string (⭐⭐)

## Exercise description:

Implement the CountCharacterFrequencies method that takes a string and returns a dictionary mapping each character to the number of times it appears in the input.

The method should be case-sensitive, so 'H' and 'h' are treated as different characters. All characters, including spaces and symbols, should be counted.


What you'll practice:

    Iterating over strings

    Using a Dictionary to store and update values

    Writing conditional logic to manage existing keys

    Optionally using LINQ for grouping and counting (GroupBy and Count)

Example usage:

    var result = CountCharacterFrequencies("Hello!");
    // result: { ['H'] = 1, ['e'] = 1, ['l'] = 2, ['o'] = 1, ['!'] = 1 }