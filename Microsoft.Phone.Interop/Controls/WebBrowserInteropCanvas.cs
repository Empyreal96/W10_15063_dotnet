// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserInteropCanvas
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  internal class WebBrowserInteropCanvas : Canvas
  {
    private readonly PanZoomContainer _panZoomContainer;
    private readonly double _logicalToPhysicalScaleFactor;

    public WebBrowserInteropCanvas(PanZoomContainer panZoomContainer)
    {
      this._panZoomContainer = panZoomContainer;
      this._logicalToPhysicalScaleFactor = !QuirksMode.ShouldApplyScaleFactorToWebBrowserControlContent() ? 1.0 : (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
      this.RenderTransform = (Transform) new ScaleTransform()
      {
        ScaleX = (1.0 / this._logicalToPhysicalScaleFactor),
        ScaleY = (1.0 / this._logicalToPhysicalScaleFactor)
      };
      this.Background = (Brush) new SolidColorBrush(Colors.Transparent);
      this.Children.Add((UIElement) this._panZoomContainer);
      this.SizeChanged += new SizeChangedEventHandler(this.OnSizeChanged);
    }

    private new void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
      Size size;
      ref Size local = ref size;
      Size newSize = e.NewSize;
      double width = newSize.Width * this._logicalToPhysicalScaleFactor;
      newSize = e.NewSize;
      double height = newSize.Height * this._logicalToPhysicalScaleFactor;
      local = new Size(width, height);
      this._panZoomContainer.Width = size.Width;
      this._panZoomContainer.Height = size.Height;
      this._panZoomContainer.UpdateLayout();
    }
  }
}
