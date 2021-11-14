// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Control))]
  [WebHostHidden]
  [Guid(1138818576, 5356, 17022, 140, 87, 222, 230, 13, 246, 10, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IControl2
  {
    bool IsTextScaleFactorEnabled { get; set; }
  }
}
