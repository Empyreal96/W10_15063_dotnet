// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitView2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1588059152, 52355, 16538, 130, 249, 62, 145, 214, 215, 8, 79)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitView))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISplitView2
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
