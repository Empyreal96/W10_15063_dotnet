// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyPropertyStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DependencyProperty))]
  [Guid(1239806607, 33369, 19804, 170, 224, 131, 213, 109, 187, 104, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDependencyPropertyStatics
  {
    object UnsetValue { get; }

    DependencyProperty Register(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata typeMetadata);

    DependencyProperty RegisterAttached(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata defaultMetadata);
  }
}
