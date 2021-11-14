// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Resources.ICustomXamlResourceLoaderOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Resources
{
  [Guid(4166117777, 44802, 18152, 154, 248, 66, 123, 126, 191, 233, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CustomXamlResourceLoader))]
  internal interface ICustomXamlResourceLoaderOverrides
  {
    object GetResource(
      string resourceId,
      string objectType,
      string propertyName,
      string propertyType);
  }
}
