// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PnpObject))]
  [Guid(2512806488, 29499, 19087, 147, 163, 219, 7, 138, 200, 112, 193)]
  internal interface IPnpObject
  {
    PnpObjectType Type { get; }

    string Id { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }

    void Update(PnpObjectUpdate updateInfo);
  }
}
