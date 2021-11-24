using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodewarriorsApp {
    public static class TestClass {
        public static bool Narcissistic(int value) {
            string stringValue = value.ToString();
            int length = stringValue.Length;
            IEnumerable<int> digits = stringValue.ToCharArray().Select(x => Convert.ToInt32(x.ToString()));

            int totalSum = 0;

            foreach (int digit in digits) {
                int poweredVal = (int)Math.Pow(digit, length);
                totalSum += poweredVal;
            }

            return value == totalSum;
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) {
            foreach (object obj in listOfItems) {
                if (obj is int) {
                    yield return (int)obj;
                }
            }
        }

        public static int DescendingOrder(int num) {
            string str = num.ToString();
            string numbersOrdered = String.Join("", str.OrderByDescending(x => x));

            if (Int32.TryParse(numbersOrdered, out int number)) {
                return number;
            } else {
                return Int32.MaxValue;
            };
        }

        public static int find_it(int[] seq) {
            Dictionary<int, int> counterDict = new Dictionary<int, int>();

            foreach (int number in seq) {
                if (counterDict.ContainsKey(number)) {
                    counterDict[number]++;
                } else {
                    counterDict.Add(number, 1);
                }
            }

            return counterDict.First(x => x.Value % 2 != 0).Key;
        }

        public static String Accum(string s) {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++) {
                string letter = s[i].ToString();

                if (i > 0) {
                    sb.Append("-");

                    for (int k = 0; k < i; k++) {
                        if (k == 0) {
                            sb.Append(letter.ToUpper());
                        } else {
                            sb.Append(letter.ToLower());
                        }
                    }
                } else {
                    sb.Append(letter.ToUpper());
                }
            }

            return sb.ToString();
        }

        public static String Accum1(string s) {
            return String.Join("-", s.Select((x, i) => $"{char.ToUpper(x)}{new string(char.ToLower(x), i)}"));
        }
    }
}
