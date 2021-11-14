// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotItemEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PivotItemEventArgs))]
  [WebHostHidden]
  [Guid(443511380, 7893, 19397, 160, 96, 101, 85, 48, 188, 166, 186)]
  internal interface IPivotItemEventArgs
  {
    PivotItem Item { get; set; }
  }
}
