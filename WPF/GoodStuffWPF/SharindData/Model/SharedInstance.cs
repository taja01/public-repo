using SharindData.ViewModel;

namespace SharindData.Model
{
    public class SharedInstance
    {
        public static SharedViewModel SharedViewModel { get; } = new SharedViewModel();
    }
}
