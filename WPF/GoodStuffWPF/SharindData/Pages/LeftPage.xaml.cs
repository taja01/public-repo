using SharindData.Model;
using SharindData.ViewModel;
using System.Windows.Controls;

namespace SharindData.Pages
{
    /// <summary>
    /// Interaction logic for LeftPage.xaml
    /// </summary>
    public partial class LeftPage : Page
    {
        private readonly SharedViewModel _viewModel;

        public LeftPage()
        {
            InitializeComponent();


            lbBox.ItemsSource = new[] { "1", "2", "3", "4" };
            _viewModel = SharedInstance.SharedViewModel;
        }

        private void tbTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_viewModel == null)
            {
                return;
            }
            _viewModel.Name = tbTextBox.Text;
        }

        private void lbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_viewModel == null)
            {
                return;
            }

            _viewModel.Items = lbBox.SelectedItems.Cast<string>().ToList();
        }
    }
}
