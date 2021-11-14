// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(125512164, 56030, 20309, 155, 150, 9, 226, 27, 40, 235, 28)]
  [ExclusiveTo(typeof (Control))]
  [WebHostHidden]
  internal interface IControl3
  {
    bool UseSystemFocusVisuals { get; set; }
  }
}
