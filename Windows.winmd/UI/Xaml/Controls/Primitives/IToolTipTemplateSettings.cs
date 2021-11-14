// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IToolTipTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3560473159, 3780, 17670, 175, 253, 175, 172, 34, 37, 180, 140)]
  [ExclusiveTo(typeof (ToolTipTemplateSettings))]
  [WebHostHidden]
  internal interface IToolTipTemplateSettings
  {
    double FromHorizontalOffset { get; }

    double FromVerticalOffset { get; }
  }
}
