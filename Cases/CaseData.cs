using OpenCdsi.Cases;

namespace OpenCdsi
{
    public class CaseLibrary
    {
        private static readonly IReadOnlyDictionary<string, testcase> _cases = (IReadOnlyDictionary<string, testcase>)Factories.CreateTestcaseMap();
        public static IReadOnlyDictionary<string, testcase> Cases => _cases;
        public static string ResourceVersion =>Metadata.ResourceVersion;
    }
}
