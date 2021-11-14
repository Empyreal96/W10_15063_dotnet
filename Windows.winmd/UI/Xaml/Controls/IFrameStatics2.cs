// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrameStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3837119998, 17136, 17506, 161, 193, 93, 37, 157, 216, 42, 3)]
  internal interface IFrameStatics2
  {
    DependencyProperty BackStackProperty { get; }

    DependencyProperty ForwardStackProperty { get; }
  }
}
