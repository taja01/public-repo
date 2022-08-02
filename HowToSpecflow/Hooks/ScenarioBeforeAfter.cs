using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.ValueRetrievers;

namespace HowToSpecflow.Hooks
{
    [Binding]
    internal sealed class BeforeAfterTest
    {
        [BeforeTestRun]
        public static void BeforeTest()
        {
            //ParsingTable
            Service.Instance.ValueRetrievers.Register(new NullValueRetriever("null"));
        }

    }
}
