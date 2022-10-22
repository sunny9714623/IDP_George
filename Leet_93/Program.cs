namespace Leet_93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RestoreIpAddresses("12825343");
        }

        List<string> ans = new List<string>();
        int _seg = 4;
        public int[] num = new int[4];
        public IList<string> RestoreIpAddresses(string s)
        {
            DFS(s, 0, 0);
            return ans;
        }

        public void DFS(string s,int segId,int startId)
        {
            // 找到一个满足条件的解
            if(segId == _seg)
            {
                if(startId == s.Length)
                {
                    string str = "";
                    for(int i = 0; i < num.Length; i++)
                    {
                        str += num[i];
                        if (i != num.Length - 1)
                        {
                            str += ".";
                        }
                    }
                    ans.Add(str);
                }
                return;
            }
            if (startId == s.Length) //没找到4段，但是字符串用完了
            {
                return;
            }
            if (s[startId] == '0')
            {
                num[segId] = 0;
                DFS(s, segId + 1, startId + 1);
            }

            // 一般情况
            int add = 0;
            for(int end = startId; end < s.Length; end++)
            {
                add = add * 10 + s[end] - '0';
                if(add > 0 && add <= 255)
                {
                    num[segId] = add;
                    DFS(s, segId + 1, end + 1);
                }
                else
                {
                    break;
                }
            }
        }
    }
}