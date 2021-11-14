// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubSection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HubSection))]
  [Guid(2766564535, 32733, 20448, 171, 73, 194, 70, 99, 157, 204, 249)]
  [WebHostHidden]
  internal interface IHubSection
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    DataTemplate ContentTemplate { get; set; }

    bool IsHeaderInteractive { get; set; }
  }
}
