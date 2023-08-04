using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCanvasApp.Views
{
    public partial class AutoClipView : UserControl
    {
        public AutoClipView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
