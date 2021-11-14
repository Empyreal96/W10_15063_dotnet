// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBox3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(1379928675, 18284, 19382, 183, 129, 1, 147, 36, 211, 254, 217)]
  internal interface IComboBox3
  {
    LightDismissOverlayMode LightDismissOverlayMode { get; set; }

    bool IsTextSearchEnabled { get; set; }
  }
}
