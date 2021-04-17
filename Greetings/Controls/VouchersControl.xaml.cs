using Greetings.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Greetings.Controls
{
    public sealed partial class VouchersControl : UserControl
    {
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<VoucherModel>), typeof(VouchersControl), new PropertyMetadata(null));

        public ObservableCollection<VoucherModel> ItemsSource
        {
            get => (ObservableCollection<VoucherModel>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public VouchersControl()
        {
            this.InitializeComponent();
        }
    }
}