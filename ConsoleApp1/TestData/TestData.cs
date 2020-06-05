using System.Collections;
using NUnit.Framework;

namespace TAProject1
{
    public class TestDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("158", "tesdec5");
                yield return new TestCaseData("808", "testdec55");

            }
        }
    }
}
