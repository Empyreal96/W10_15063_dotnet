// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3313389928, 15102, 17549, 183, 82, 47, 54, 76, 117, 215, 67)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScrollEventArgs))]
  internal interface IScrollEventArgs
  {
    double NewValue { get; }

    ScrollEventType ScrollEventType { get; }
  }
}
