using Windows.UI.Xaml.Media;

namespace Greetings.Models
{
    internal class VoucherModel
    {
        internal string Name { get; set; }

        internal double Price { get; set; }

        internal double Stars { get; set; }

        internal bool Like { get; set; }

        internal string Location { get; set; }

        internal ImageSource ImageSource { get; set; }
    }
}