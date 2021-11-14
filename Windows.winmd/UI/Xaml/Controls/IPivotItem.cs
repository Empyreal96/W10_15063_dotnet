// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2759213937, 42242, 18339, 145, 94, 74, 160, 150, 218, 248, 127)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PivotItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPivotItem
  {
    object Header { get; set; }
  }
}
