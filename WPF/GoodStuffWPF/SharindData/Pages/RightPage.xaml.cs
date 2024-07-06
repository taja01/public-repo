using SharindData.Model;
using SharindData.ViewModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace SharindData.Pages
{
    /// <summary>
    /// Interaction logic for RightPage.xaml
    /// </summary>
    public partial class RightPage : Page
    {
        private SharedViewModel _viewModel;
        public RightPage()
        {
            InitializeComponent();

            _viewModel = SharedInstance.SharedViewModel;

            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                tbTextBox.Text = _viewModel.Name;
            }

            if (e.PropertyName == "Items")
            {
                lbBox.ItemsSource = _viewModel.Items;
            }
        }
    }
}
