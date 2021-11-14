// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserDesignTime
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace Microsoft.Phone.Controls
{
  internal class WebBrowserDesignTime : WebBrowserNoOp
  {
    private FrameworkElement presentation;

    public override FrameworkElement GetPresentation()
    {
      if (this.presentation == null)
      {
        StreamResourceInfo resourceStream = Application.GetResourceStream(new Uri("Microsoft.Phone.Interop;component/tokenie.png", UriKind.Relative));
        BitmapImage bitmapImage = new BitmapImage();
        bitmapImage.SetSource(resourceStream.Stream);
        this.presentation = (FrameworkElement) new Image()
        {
          Source = (ImageSource) bitmapImage,
          Stretch = Stretch.None
        };
      }
      return this.presentation;
    }
  }
}
