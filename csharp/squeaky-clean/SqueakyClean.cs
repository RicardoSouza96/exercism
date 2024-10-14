using System;
using System.Text;

//Updating the branch name

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder newString = new StringBuilder();
        char ch;
        for (int i = 0; i < identifier.Length; i++)
        {
            ch = identifier[i];

            if (ch == ' ')
                ch = '_';

            if (Char.IsControl(ch))
            {
                newString.Append("CTRL");
                continue;
            }
            if(ch == '-')
            {
                ch = identifier[i + 1];
                newString.Append(Char.ToUpper(ch));
                i++;
                continue;
            }
            if (!Char.IsLetter(ch) && ch != '_')
                continue;

            if (ch >= 'α' && ch <= 'ω')
                continue;

            newString.Append(ch);
        }
        return newString.ToString();
    }
}


