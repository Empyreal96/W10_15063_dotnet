// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVirtualizingPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(950719756, 4815, 19742, 168, 132, 201, 223, 133, 240, 124, 217)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VirtualizingPanel))]
  internal interface IVirtualizingPanel
  {
    ItemContainerGenerator ItemContainerGenerator { get; }
  }
}
