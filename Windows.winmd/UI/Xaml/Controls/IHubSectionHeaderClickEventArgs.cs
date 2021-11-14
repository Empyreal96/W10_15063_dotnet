// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubSectionHeaderClickEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3787845380, 7901, 16658, 174, 235, 153, 108, 150, 64, 6, 152)]
  [ExclusiveTo(typeof (HubSectionHeaderClickEventArgs))]
  [WebHostHidden]
  internal interface IHubSectionHeaderClickEventArgs
  {
    HubSection Section { get; }
  }
}
