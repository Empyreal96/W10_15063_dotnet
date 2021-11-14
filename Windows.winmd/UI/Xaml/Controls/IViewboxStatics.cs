// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IViewboxStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1557260077, 59603, 18533, 143, 8, 182, 178, 214, 137, 173, 241)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Viewbox))]
  internal interface IViewboxStatics
  {
    DependencyProperty StretchProperty { get; }

    DependencyProperty StretchDirectionProperty { get; }
  }
}
