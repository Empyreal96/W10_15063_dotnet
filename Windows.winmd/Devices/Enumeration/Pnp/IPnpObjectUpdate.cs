// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObjectUpdate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [Guid(1868163090, 30, 18500, 188, 198, 67, 40, 134, 133, 106, 23)]
  [ExclusiveTo(typeof (PnpObjectUpdate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPnpObjectUpdate
  {
    PnpObjectType Type { get; }

    string Id { get; }

    IMapView<string, object> Properties { [return: HasVariant] get; }
  }
}
