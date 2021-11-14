// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubSectionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4294270882, 60644, 19386, 170, 59, 152, 4, 174, 244, 120, 131)]
  [ExclusiveTo(typeof (HubSection))]
  internal interface IHubSectionFactory
  {
    HubSection CreateInstance(object outer, out object inner);
  }
}
