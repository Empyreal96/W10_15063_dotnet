// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHyperlinkButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (HyperlinkButton))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3437997219, 15196, 20300, 155, 253, 134, 136, 123, 199, 151, 114)]
  internal interface IHyperlinkButton
  {
    Uri NavigateUri { get; set; }
  }
}
