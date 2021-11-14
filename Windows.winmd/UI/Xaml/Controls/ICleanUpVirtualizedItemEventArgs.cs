// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICleanUpVirtualizedItemEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3926248681, 37756, 16672, 132, 6, 121, 33, 133, 120, 67, 56)]
  [ExclusiveTo(typeof (CleanUpVirtualizedItemEventArgs))]
  internal interface ICleanUpVirtualizedItemEventArgs
  {
    object Value { get; }

    UIElement UIElement { get; }

    bool Cancel { get; set; }
  }
}
