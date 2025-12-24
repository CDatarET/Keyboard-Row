public class Solution {
    public string[] FindWords(string[] words) {
        string r1 = "qwertyuiop";
        string r2 = "asdfghjkl";
        string r3 = "zxcvbnm";

        List<string> ret = new List<string>();

        foreach (string s in words)
        {
            int row = 0;
            bool inv = false;

            foreach (char c in s.ToLower())
            {
                if (r1.IndexOf(c) != -1)
                {
                    if (row >= 2)
                    {
                        inv = true;
                        break;
                    }
                    row = 1;
                }
                else if (r2.IndexOf(c) != -1)
                {
                    if (row == 1 || row == 3)
                    {
                        inv = true;
                        break;
                    }
                    row = 2;
                }
                else // r3
                {
                    if (row == 1 || row == 2)
                    {
                        inv = true;
                        break;
                    }
                    row = 3;
                }
            }

            if (!inv)
            {
                ret.Add(s);
            }
        }

        return ret.ToArray();
    }
}
