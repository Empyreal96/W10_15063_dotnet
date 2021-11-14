// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyMetadataStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(989923194, 28166, 17897, 139, 92, 175, 36, 52, 88, 192, 98)]
  [ExclusiveTo(typeof (PropertyMetadata))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPropertyMetadataStatics
  {
    [Overload("CreateWithDefaultValue")]
    [DefaultOverload]
    PropertyMetadata Create(object defaultValue);

    [DefaultOverload]
    [Overload("CreateWithDefaultValueAndCallback")]
    PropertyMetadata Create(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback);

    [Overload("CreateWithFactory")]
    PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback);

    [Overload("CreateWithFactoryAndCallback")]
    PropertyMetadata Create(
      CreateDefaultValueCallback createDefaultValueCallback,
      PropertyChangedCallback propertyChangedCallback);
  }
}
