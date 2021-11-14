// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingStackPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1969737114, 41908, 19946, 187, 17, 84, 158, 44, 47, 145, 157)]
  [ExclusiveTo(typeof (VirtualizingStackPanel))]
  [WebHostHidden]
  internal interface IVirtualizingStackPanel
  {
    bool AreScrollSnapPointsRegular { get; set; }

    Orientation Orientation { get; set; }

    event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;
  }
}
