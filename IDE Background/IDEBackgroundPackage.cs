using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Maxzhang.IDEBackground
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [Guid(GuidList.guidIDE_BackgroundPkgString)]
    [ProvideAutoLoad(UIContextGuids.NoSolution)]
    [ProvideAutoLoad(UIContextGuids.SolutionExists)]
    public sealed class IDEBackgroundPackage : Package
    {
        protected override void Initialize()
        {
            base.Initialize();

            Application.Current.MainWindow.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var rWindow = (Window)sender;
           
            //加载图片
            var rImageSource = BitmapFrame.Create(new Uri(@"C:\Users\maxzhang\Pictures\1012.png"/*图片路径*/), BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            rImageSource.Freeze();

            var rImageControl = new Image()
                {
                    Source = rImageSource,
                    Stretch = Stretch.UniformToFill, //按比例填充
                    HorizontalAlignment = HorizontalAlignment.Center, //水平方向中心对齐
                    VerticalAlignment = VerticalAlignment.Center, //垂直方向中心对齐
                };

            Grid.SetRowSpan(rImageControl, 4);
            var rRootGrid = (Grid)rWindow.Template.FindName("RootGrid", rWindow);
            rRootGrid.Children.Insert(0, rImageControl);
        }
    }
}
