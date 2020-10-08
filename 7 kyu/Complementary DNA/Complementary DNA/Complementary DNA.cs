public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        string proper_dna = "";
        for (int i = 0; i < dna.Length; i++)
        {

            if (dna[i] == 'A')
            {
                proper_dna = proper_dna + "T";
            }
            else if (dna[i] == 'T')
            {
                proper_dna = proper_dna + "A";
            }
            else if (dna[i] == 'C')
            {
                proper_dna = proper_dna + "G";
            }
            else if (dna[i] == 'G')
            {
                proper_dna = proper_dna + "C";
            }
        }
        return proper_dna;
    }
}