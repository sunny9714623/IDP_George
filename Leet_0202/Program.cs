using System.Text;

namespace Leet_0202
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string line = System.Console.ReadLine();
            int n = int.Parse(line);
            for (int i = 0; i < n; i++)
            {
                int result1 = 0;
                string s1 = System.Console.ReadLine();
                int[] map = new int[26];
                for (int j = 0; j < s1.Length; j++)
                {
                    map[s1[j] - 'a']++;
                }

                System.Array.Sort(map);
                Array.Reverse(map);
                int pl = 26;
                for (int j = 0; j < map.Length; j++)
                {
                    if (map[j] != 0)
                    {
                        while (map[j] != 0)
                        {
                            result1 += pl;
                            map[j]--;
                        }
                        pl--;
                    }
                }
                System.Console.WriteLine(result1);
            }
            //string line;

            //line = Console.ReadLine();
            //string[] words = line.Split(new string[] { ",", " ", "." }, StringSplitOptions.RemoveEmptyEntries);
            //int count = 0;
            //for(int i = 0; i < words.Length; i++)
            //{
            //    count += words[i].Length;    
            //}

            // System.Console.WriteLine((count*1.0/words.Length).ToString("0.00"));
            //while ((line = System.Console.ReadLine()) != null)
            //{ // 注意 while 处理多个 case
            //    int max = 0;
            //    for (int i = 0; i < line.Length; i++)
            //    {
            //        int max1 = GetMaxLength(line, i, i);
            //        int max2 = GetMaxLength(line, i, i + 1);
            //        max = System.Math.Max(max, max1 > max2 ? max1 : max2);
            //    }
            //    System.Console.WriteLine(max);
            //}

            // a+aa+aaa+aaaa+aaaa (a,n)
            //string l1 = System.Console.ReadLine();
            //string l2 = System.Console.ReadLine();
            //int inta = int.Parse(l1);
            //int intn = int.Parse(l2);
            //int sum = 0, s = 0;
            //for(int i = 0; i < intn; i++)
            //{
            //    s += inta;
            //    sum += s;
            //    inta = inta * 10;
            //}
            //Console.WriteLine(sum);

            string[] lines = System.Console.ReadLine().Split();
            Array.Sort(lines);
            bool[] visited = new bool[lines.Length];
            List<string> result = new List<string>();
            DFS(result, lines, "", visited);

            //Console.WriteLine(a1);
            string a = "87321873781231231221231231";
            string b = "2313718231290";
            StringBuilder sb = new StringBuilder();
            if (a.Length > b.Length)
            {
                int subLength = a.Length - b.Length;
                for (int i = 0; i < subLength; i++)
                {
                    b = "0" + b;
                }
            }
            else if (a.Length < b.Length)
            {
                int subLength = b.Length - a.Length;
                for (int i = 0; i < subLength; i++)
                {
                    a = "0" + a;
                }
            }

            int jinwei = 0;
            for(int i = a.Length - 1; i >= 0; i--)
            {
                sb.Append((a[i] - '0' + b[i] - '0' + jinwei) % 10);
                if (a[i] - '0' + b[i] - '0' + jinwei > 10)
                    jinwei = 1;
                else
                    jinwei = 0;
            }
            if (jinwei == 1)
            {
                sb.Append(jinwei);
            }
            var char1 = sb.ToString().ToCharArray();
            Array.Reverse(char1);
            System.Console.WriteLine(char1);

            while (true)
            {
                var line11 = Console.ReadLine();
                var line22 = Console.ReadLine();
            }
            // Console.WriteLine(Convert.ToString(234, 6));

            Convert.ToString(2323, 5);

            //int line = int.Parse(System.Console.ReadLine());
            //IDictionary<string, int> dic = new Dictionary<string, int>();
            //for (int i = 0; i < line; i++)
            //{
            //    string[] input = System.Console.ReadLine().Split(" ");
            //    if (dic.Keys.Contains(input[0]))
            //    {
            //        dic[input[0]] += int.Parse(input[1]);
            //    }
            //    else
            //    {
            //        dic[input[0]] = int.Parse(input[1]);
            //    }
            //}
            //dic = dic.OrderBy(t=>t.Key).ToDictionary(dic=>dic.Key, dic=>dic.Value);
            //foreach (var key in dic.Keys)
            //{
            //    System.Console.WriteLine(key + " "+ dic[key]);
            //}
            //HashSet<string> list = new HashSet<string>();

            //while ((line = System.Console.ReadLine()) != null)
            //{ // 注意 while 处理多个 case
            //    //int bottle = int.Parse(line);
            //    //if (bottle == 0) break;
            //    //int count = 0;
            //    //while (bottle / 3 != 0)
            //    //{
            //    //    count += bottle / 3;
            //    //    bottle = bottle / 3 + bottle % 3;
            //    //}
            //    //if (bottle == 2)
            //    //{
            //    //    count += 1;
            //    //}
            //    //System.Console.WriteLine(count);


            //}
            // 这样可以把字符串转成二进制;
            //Console.WriteLine(Convert.ToString(5, 2));

            // 任何数与二进制1进行与运算都得1;

            //string line = System.Console.ReadLine();
            //string[] lines = line.Split(" ");
            //IList<int> nums = new List<int>();
            //nums[0] = int.Parse(lines[1]);
            //for (int i = 1, j = 2; i < int.Parse(lines[0]); i++, j += 2)
            //{
            //    nums.Insert(nums.IndexOf(int.Parse(lines[j + 1])), int.Parse(lines[j]));
            //}

            //nums.RemoveAt(nums.IndexOf(int.Parse(lines[lines.Length - 1])));
            //foreach (var num in nums)
            //{
            //    System.Console.Write(num + " ");
            //}

            //int n=2, m=2;
            //int[,] step = new int[,] { { 0, 1 }, { 1, 0 } };

            //int[,] dp = new int[m+1, n+1];
            //for(int i = 0; i < dp.GetLength(0); i++)
            //{
            //    dp[0, i] = 1;
            //}
            //for(int i = 0; i < dp.GetLength(1); i++)
            //{
            //    dp[i, 0] = 1;
            //}
            //for(int i = 1; i < dp.GetLength(0); i++)
            //{
            //    for(int j = 1; j < dp.GetLength(1); j++)
            //    {
            //        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
            //    }
            //}

            //System.Console.WriteLine("********");
            //System.Console.WriteLine(dp[m, n]);


            //string line;
            //while ((line = System.Console.ReadLine()) !=
            //        null)
            //{ // 注意 while 处理多个 case
            //    if (line.Contains('.'))
            //    {
            //        string[] lines = line.Split('.');
            //        long result = 0;
            //        for (int i = 0; i < lines.Length; i++)
            //        {
            //            result = result * 256 + int.Parse(lines[i]);
            //        }
            //        System.Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        long result = long.Parse(line);
            //        int[] ips = new int[4];
            //        for (int i = 3; i >= 0; i--)
            //        {
            //            ips[i] = (int)(result % 256);
            //            result = result / 256;
            //        }
            //        for (int i = 0; i < 4; i++)
            //        {
            //            if (i != 3)
            //            {
            //                System.Console.Write(ips[i] + ".");
            //            }
            //            else
            //                System.Console.Write(ips[i]);
            //        }
            //    }
            //}
            //string line;
            while ((line = System.Console.ReadLine()) != null)
            { // 注意 while 处理多个 case
                string[] tokens = line.Split(" ");
                //int n = int.Parse(tokens[0]) + 1;
                int m = int.Parse(tokens[1]) + 1;
                int[,] dp = new int[m, n];
                for (int i = 0; i < dp.GetLength(0); i++)
                {
                    dp[i, 0] = 1;
                }
                for (int i = 0; i < dp.GetLength(1); i++)
                {
                    dp[0, i] = 1;
                }
                for (int i = 1; i < dp.GetLength(0); i++)
                {
                    for (int j = 1; j < dp.GetLength(1); j++)
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
                System.Console.WriteLine(dp[m-1, n-1]);
            }


            string line1 = System.Console.ReadLine();
            char[] charline1 = line1.ToCharArray();
            string line2 = System.Console.ReadLine();
            char[] charline2 = line2.ToCharArray();
            // 加密
            for(int i = 0; i < charline1.Length; i++)
            {
                if (char.IsLetter(charline1[i]) && charline1[i] != 'Z' && charline1[i] != 'z')
                {
                    if (char.IsUpper(charline1[i]))
                        charline1[i] = char.ToLower(char.Parse(char.ConvertFromUtf32(charline1[i] + 1)));
                    else
                    {
                        charline1[i] = char.ToUpper(char.Parse(char.ConvertFromUtf32(charline1[i] + 1)));
                    }
                }
                else if(charline1[i] == 'Z' || charline1[i] == 'z')
                {
                    if (charline1[i] == 'Z') charline1[i] = 'a';
                    else
                        charline1[i] = 'A';
                }
                if (char.IsDigit(charline1[i]) && charline1[i]!=9)
                {
                    charline1[i] = char.Parse(char.ConvertFromUtf32(charline1[i] + 1));
                }
                else if (charline1[i] == '9')
                {
                    charline1[i] = '0';
                }
            }

            Console.WriteLine(new string(charline1));

            // 解密
        }

        private static bool JudgeHasString(string s)
        {
            // 通过hasSet判断
            HashSet<string> set = new HashSet<string>();
            for(int i = 0; i < s.Length - 3; i++)
            {
                if (!set.Add(s.Substring(i, 3))) return true;
            }
            return false;
        }

        private static void AddString(string value)
        {
            value += "2022";
            float.Parse("0.231");
        
        }

        public static int KthToLast(ListNode head, int k)
        {
            ListNode p2 = head,p1 = head;
            for(int i = 0; i < k; i++)
            {
                p2 = p2.next;
            }
            while (p2 != null)
            {
                p2 = p2.next;
                p1 = p1.next;
            }
            return p1.val;
        }

        private static int GetMaxLength(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            return r - l - 1;
        }

        private static int ConvertTo10string(string s,int b)
        {
            int result = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    result = result * b + (char.ToUpper(s[i]) - 'A') + 10;
                }
                else
                {
                    result = result * b + (char.ToUpper(s[i]) - '0');
                }
            }
            return result;
        }

        private static string ConvertToBString(int value, int b)
        {
            string ret = "";
            while (value != 0)
            {
                ret = (value % b > 9 ? char.ConvertFromUtf32(value % b - 10 + 'a') : value % b) + ret;
                value = value / b;
            }
            return ret;
        }

        private static void DFS(List<string> result,string[] nums, string s, bool[] b)
        {
            if(s.Length == nums.Length)
            {
                result.Add(s);
                return;
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1] && b[i - 1])
                {
                    continue;
                }
                if (!b[i])
                {
                    b[i] = true;
                    DFS(result, nums, s + nums[i], b);
                    b[i] = false;
                }
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class A
    {
        public virtual void Test()
        {
            Console.WriteLine("This is TestA");
        }
    }

    public class B : A
    {
        public override void Test()
        {
            Console.WriteLine("This is TestB");
        }
    }

    public class C: A
    {
        public new void Test()
        {
            Console.WriteLine("This is TestC");
        }
    }
}