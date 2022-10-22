namespace Leet_475
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] house = new int[] { 1,5};
            int[] heaters = new int[] { 10 };
            //int[] house = new int[] { 282475249, 622650073, 984943658, 144108930, 470211272, 101027544, 457850878, 458777923 };
            //int[] heaters = new int[] { 823564440, 115438165, 784484492, 74243042, 114807987, 137522503, 441282327, 16531729, 823378840, 143542612 };
            int result = FindRadius(house, heaters);
        }

        /// <summary>
        /// 排序加二分查找
        /// </summary>
        /// <param name="houses"></param>
        /// <param name="heaters"></param>
        /// <returns></returns>
        //public static int FindRadius(int[] houses, int[] heaters)
        //{
        //    Array.Sort(heaters);
        //    int radius = 0, d;
        //    //对于每个房屋，要么用前面的暖气，要么用后面的，二者取近的，得到距离
        //    foreach (int house in houses)
        //    {
        //        if(house <= heaters[0])
        //        {
        //            d = heaters[0] - house;
        //        }
        //        else if (house >= heaters[heaters.Length - 1])
        //        {
        //            d = house - heaters[heaters.Length - 1];
        //        }
        //        else
        //        {
        //            bool flag = false;
        //            int left = 0, right = heaters.Length - 1;
        //            while (left < right)
        //            {
        //                int mid = (left + right) >> 1;
        //                if (house > heaters[mid])
        //                {
        //                    left = mid + 1;
        //                }
        //                //else if (house == heaters[mid])
        //                //{
        //                //    flag = true;
        //                //    break;
        //                //}
        //                //else
        //                //{
        //                //    right = mid - 1;
        //                //}
        //                else
        //                {
        //                    right = mid;
        //                }
        //            }
        //            // 没找到时，left的值一定大于house
        //            d = flag ?  0 : Math.Min(heaters[left] - house, house - heaters[left - 1]);
        //        }
        //        radius = Math.Max(radius, d);
        //    }
        //    return radius;
        //}

        // 排序加双指针
        public static int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            List<int> copyHeadters = new List<int>(heaters);
            copyHeadters.Add(int.MaxValue);
            copyHeadters.Add(int.MinValue);
            copyHeadters.Sort();
            int cur = 0; long  r = 0;
            for(int i = 0; i < houses.Length; i++)
            {
                while (cur < copyHeadters.Count && copyHeadters[cur] < houses[i])
                {
                    cur++;
                }
                r = Math.Max(r, Math.Min(((long)copyHeadters[cur] - (long)houses[i]), (long)houses[i] - (long)copyHeadters[cur - 1]));
            }
            return (int)r;
        }
    }
}