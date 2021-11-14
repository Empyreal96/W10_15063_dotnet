// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHyperlinkButtonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (HyperlinkButton))]
  [Guid(1129454509, 20119, 19881, 166, 77, 147, 93, 253, 140, 237, 242)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHyperlinkButtonFactory
  {
    HyperlinkButton CreateInstance(object outer, out object inner);
  }
}
