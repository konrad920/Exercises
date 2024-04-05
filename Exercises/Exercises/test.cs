//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exercises
//{
//    public class MergeNames
//    {
//        public static string[] UniqueNames(string[] names1, string[] names2)
//        {
//            var uniqNames = new string[names1.Length + names2.Length];
//            for (int i=0; i<names1.Length; i++)
//            {
//                uniqNames[i] = names1[i];
//            }


//            for (int i=0; i<names2.Length; i++)
//            {
//                for (int j = 0; j < uniqNames.Length; j++)
//                {
//                    if (uniqNames[j] == names2[i])
//                    {
//                        break;
//                    }
//                    else if (uniqNames[j] != names2[i] && j<uniqNames.Length-1)
//                    {
//                        continue;
//                    }
//                    else if (uniqNames[j] != names2[i] && j == uniqNames.Length - 1)
//                    {
//                        var count = 0;
//                        uniqNames[names1.Length+count] = names2[i];
//                        count++;
//                    }
//                }
//            }
//            return uniqNames;
//        }

//        public static void Main(string[] args)
//        {
//            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
//            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
//            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
//        }

//        public void Main()
//        {
//            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
//            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
//            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2)));
//        }
//    }
//}
