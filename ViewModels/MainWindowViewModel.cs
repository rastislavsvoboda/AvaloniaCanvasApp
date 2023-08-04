using System.Collections.ObjectModel;
using Avalonia;
using AvaloniaCanvasApp.Models;
using AvaloniaCanvasApp.ViewModels.Shapes;
using DynamicData;

namespace AvaloniaCanvasApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ShapeViewModel> Shapes { get; }

        public MainWindowViewModel()
        {
            Shapes = new ObservableCollection<ShapeViewModel>();

            Shapes.AddRange(new ShapeViewModel[]
            {
                new RectangleShapeViewModel()
                {
                    Location = new Point(300, 300),
                    Size = new Size(100, 80),
                    Fill = "Red"
                },
                new AutoClipShapeViewModel()
                {
                    Location = new Point(200, 500),
                    Size = new Size(100, 80),
                    Text = "Autoclip",
                    Fill = "Green",
                    Color = "Yellow",
                    OutlineColor = "Blue",
                    OutlineWidth = 3,
                    VerticalAlignment = VerticalAlignments.Center,
                    HorizontalAlignment= HorizontalAlignments.Center,
                    
                },
                new PizzaShapeViewModel()
                {
                    Location = new Point(100, 300),
                    Size = new Size(100, 100),
                    Fill = "Aqua"
                },
            });
        }
    }
}