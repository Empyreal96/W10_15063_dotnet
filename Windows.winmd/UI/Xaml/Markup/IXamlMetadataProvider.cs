// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlMetadataProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  [WebHostHidden]
  [Guid(3010878825, 26789, 19250, 136, 97, 253, 185, 12, 31, 88, 54)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IXamlMetadataProvider
  {
    [DefaultOverload]
    [Overload("GetXamlType")]
    IXamlType GetXamlType(TypeName type);

    [Overload("GetXamlTypeByFullName")]
    IXamlType GetXamlType(string fullName);

    XmlnsDefinition[] GetXmlnsDefinitions();
  }
}
