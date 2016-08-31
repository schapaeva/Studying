using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareVersions
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
        public int CompareVersion(string version1, string version2)
        {
            int[] ver1 = Array.ConvertAll(version1.Split('.'), Int32.Parse);
            int[] ver2 = Array.ConvertAll(version2.Split('.'), Int32.Parse);
        
            if (ver1.Length != ver2.Length)
            {
                int difference = Math.Abs(ver1.Length - ver2.Length);
                if (ver1.Length < ver2.Length)
                    ver1 = AddZeros(ver1, difference);
                else if (ver1.Length > ver2.Length)
                    ver2 = AddZeros(ver2, difference);
            }
        
            for(int i = 0; i < ver1.Length; i++)
            {
                if (ver1[i] > ver2[i])
                {
                    return 1;
                }
                else if (ver1[i] < ver2[i])
                {
                    return -1;
                }
            }
            return 0;
        }

        public static int[] AddZeros(int[] version, int difference)
        {
            List<int> versionList = version.ToList();
            for (int i = 0; i < difference; i++)
            {
                versionList.Add(0);
            }
            return versionList.ToArray();
        }
    }
}
