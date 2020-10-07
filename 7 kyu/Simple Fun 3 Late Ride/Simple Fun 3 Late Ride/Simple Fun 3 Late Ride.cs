namespace myjinxin
{
    using System;
    using System.Text;

    public class Kata
    {
        public int LateRide(int n)
        {
            StringBuilder text = new StringBuilder();
            int m = n;
            int h = 0;
            if (n > 60)
            {
                do
                {
                    m -= 60;
                    h++;
                } while (m >= 60);
            }
            text.Append(h);
            text.Append(m);
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                sum += int.Parse(text[i].ToString());
            }
            return sum;
        }
    }
}