using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    readonly string input;
    string output;
    List<string> permutations;

    public Anagram(string input)
    {
        this.input = input;
        output = input;
        permutations = new List<string>();
    }

    public string Generate()
    {
        Scramble(input.ToCharArray());
        AddUniquePerms();
        return output;
    }

    public void Scramble(char[] toScramble)
    {
        Random rand = new Random();
        for(int i = 0; i < 1000; i++)
        {
            permutations.Add(new string(toScramble.OrderBy(x => rand.Next()).ToArray()));
        }
    }
    
    public void AddUniquePerms()
    {
        foreach(string perm in permutations)
        {
            if (!output.Contains(perm))
            {
                output += " " + perm;
            }
        }
    }
}