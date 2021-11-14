// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBar2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1466314584, 23346, 18269, 190, 100, 76, 163, 110, 123, 151, 212)]
  internal interface ICommandBar2
  {
    Style CommandBarOverflowPresenterStyle { get; set; }

    CommandBarTemplateSettings CommandBarTemplateSettings { get; }
  }
}
