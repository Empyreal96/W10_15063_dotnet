// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubSectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(315807834, 59943, 17105, 153, 139, 97, 229, 42, 237, 132, 43)]
  [ExclusiveTo(typeof (HubSection))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHubSectionStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty ContentTemplateProperty { get; }

    DependencyProperty IsHeaderInteractiveProperty { get; }
  }
}
