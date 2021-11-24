using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodewarriorsApp {
    class Program {
        static void Main(string[] args) {
            //bool isNarc = TestClass.Narcissistic(371);

            //int result = TestClass.DescendingOrder(145263);
            //string result = TestClass.Accum1("HbideVbxncC");

            //Console.WriteLine(result);
            //Console.ReadKey();

            string sizeType;

            Regex[] infantRegExps = new Regex[] {
                new Regex(@"^[0-9]+[M,T]"),
                new Regex(@"^[NB]")
            };
            Regex shorts = new Regex(@"^[W]??[0-9]{2}\Z");
            Regex junior = new Regex(@"^[0-9]{1}\Z");
            Regex pants = new Regex(@"^[W]??[0-9]{4}\Z");
            Regex plusSize = new Regex(@"^[W]??[0-9]{4}\Z");
            Regex[] regularSizes = new Regex[] {
                new Regex(@"^[1-7]??[A-Z]+?[R,T,L,P]??\Z")
            };
            Regex youthSizes = new Regex(@"^[Y]+[1-7]??[A-Z]+?");

            while (true) {
                string sizeInput = Console.ReadLine();
                string formattedSize = sizeInput.Replace(" ", "").ToUpper();

                if (infantRegExps.Any(x => x.IsMatch(formattedSize))) {
                    sizeType = "Infant";
                } else if (shorts.IsMatch(formattedSize)) {
                    sizeType = "Short";
                } else if (pants.IsMatch(formattedSize)) {
                    sizeType = "Pants";
                } else if (junior.IsMatch(formattedSize)) {
                    sizeType = "Junior";
                } else if (youthSizes.IsMatch(formattedSize)) {
                    sizeType = "Youth";
                } else if (regularSizes.Any(x => x.IsMatch(formattedSize))) {
                    sizeType = "Regular";
                } else {
                    sizeType = "Unknown";
                }

                Console.WriteLine(sizeType);
            }
        }
    }
}
