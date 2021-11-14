// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationDataContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (ApplicationDataContainer))]
  [Guid(3316579614, 62567, 16570, 133, 102, 171, 100, 10, 68, 30, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationDataContainer
  {
    string Name { get; }

    ApplicationDataLocality Locality { get; }

    IPropertySet Values { get; }

    IMapView<string, ApplicationDataContainer> Containers { get; }

    ApplicationDataContainer CreateContainer(
      string name,
      ApplicationDataCreateDisposition disposition);

    void DeleteContainer(string name);
  }
}
