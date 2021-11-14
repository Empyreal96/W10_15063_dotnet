// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBox3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2612788463, 62253, 16430, 144, 9, 5, 189, 186, 246, 51, 110)]
  [ExclusiveTo(typeof (AutoSuggestBox))]
  [WebHostHidden]
  internal interface IAutoSuggestBox3
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }
  }
}
