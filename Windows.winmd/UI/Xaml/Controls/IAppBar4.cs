// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBar4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2498480333, 2660, 19875, 191, 67, 241, 49, 0, 164, 102, 5)]
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  internal interface IAppBar4
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
