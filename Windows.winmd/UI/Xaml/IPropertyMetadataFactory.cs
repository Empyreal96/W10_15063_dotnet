// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyMetadataFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3250068672, 22477, 20271, 176, 169, 225, 128, 27, 40, 247, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PropertyMetadata))]
  [WebHostHidden]
  internal interface IPropertyMetadataFactory
  {
    PropertyMetadata CreateInstanceWithDefaultValue(
      object defaultValue,
      object outer,
      out object inner);

    PropertyMetadata CreateInstanceWithDefaultValueAndCallback(
      object defaultValue,
      PropertyChangedCallback propertyChangedCallback,
      object outer,
      out object inner);
  }
}
