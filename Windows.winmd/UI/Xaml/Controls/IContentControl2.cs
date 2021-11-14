// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1697390732, 36047, 17305, 189, 62, 90, 1, 90, 161, 188, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentControl))]
  internal interface IContentControl2
  {
    UIElement ContentTemplateRoot { get; }
  }
}
