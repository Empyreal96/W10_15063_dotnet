// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.PropertyChangedCallback
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1520405029, 53570, 17572, 130, 49, 253, 103, 103, 36, 242, 155)]
  public delegate void PropertyChangedCallback(
    DependencyObject d,
    DependencyPropertyChangedEventArgs e);
}
