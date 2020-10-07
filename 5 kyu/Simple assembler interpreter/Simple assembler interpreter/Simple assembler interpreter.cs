using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    public static class SimpleAssembler
    {
        public static Dictionary<string, int> Interpret(string[] program)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < program.Length; i++)
            {
                if (program[i].ToLower().Contains("mov"))
                {
                    if (result.ContainsKey(program[i][4].ToString()) && int.TryParse(program[i].Substring(6), out int y))
                    {
                        int value1 = int.Parse(program[i].Substring(6));
                        result[program[i][4].ToString()] = value1;
                    }
                    else if (result.ContainsKey(program[i][4].ToString()) && result.ContainsKey(program[i][6].ToString()))
                    {
                        int value2 = result.GetValueOrDefault(program[i].ToString()[6].ToString());
                        result[program[i][4].ToString()] = value2;
                    }
                    else if (int.TryParse(program[i].Substring(6), out int x))
                    {
                        result.Add(program[i].ToString()[4].ToString(), int.Parse(program[i].Substring(6)));
                    }
                    else if (result.ContainsKey(program[i][6].ToString()))
                    {
                        result.Add(program[i].ToString()[4].ToString(), result.GetValueOrDefault(program[i].ToString()[6].ToString()));
                    }
                    else
                    {

                    }
                }
                else if (program[i].Contains("inc"))
                {
                    int inc = result.GetValueOrDefault(program[i][4].ToString());
                    inc++;
                    result[program[i][4].ToString()] = inc;
                }
                else if (program[i].Contains("dec"))
                {
                    int dec = result.GetValueOrDefault(program[i][4].ToString());
                    dec--;
                    result[program[i][4].ToString()] = dec;
                }
                else if (program[i].Contains("jnz"))
                {
                    int.TryParse(program[i].ToString()[4].ToString(), out int t);

                    if (result.GetValueOrDefault(program[i][4].ToString()) != 0 || t != 0)
                    {
                        if (int.TryParse(program[i].Substring(6), out int v))
                        {
                            i += (int.Parse(program[i].Substring(6)) - 1);
                        }
                        else
                        {
                            int k = result.GetValueOrDefault(program[i][6].ToString());
                            i += k - 1;
                        }
                    }
                }
            }
            return result;
        }
    }
}