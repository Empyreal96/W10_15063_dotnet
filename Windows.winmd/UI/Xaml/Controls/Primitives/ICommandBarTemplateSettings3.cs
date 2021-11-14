// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICommandBarTemplateSettings3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CommandBarTemplateSettings))]
  [WebHostHidden]
  [Guid(1003953850, 13315, 19454, 132, 45, 44, 232, 197, 17, 210, 69)]
  internal interface ICommandBarTemplateSettings3
  {
    Visibility EffectiveOverflowButtonVisibility { get; }
  }
}
