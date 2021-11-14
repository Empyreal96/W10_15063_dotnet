// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControlStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(292127396, 23797, 19461, 165, 63, 21, 228, 135, 108, 133, 236)]
  [ExclusiveTo(typeof (ContentControl))]
  [WebHostHidden]
  internal interface IContentControlStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty ContentTemplateProperty { get; }

    DependencyProperty ContentTemplateSelectorProperty { get; }

    DependencyProperty ContentTransitionsProperty { get; }
  }
}
