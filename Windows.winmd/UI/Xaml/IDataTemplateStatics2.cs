// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DataTemplate))]
  [Guid(2331475315, 43521, 18206, 190, 221, 139, 173, 134, 33, 155, 119)]
  internal interface IDataTemplateStatics2
  {
    DependencyProperty ExtensionInstanceProperty { get; }

    IDataTemplateExtension GetExtensionInstance(FrameworkElement element);

    void SetExtensionInstance(FrameworkElement element, IDataTemplateExtension value);
  }
}
