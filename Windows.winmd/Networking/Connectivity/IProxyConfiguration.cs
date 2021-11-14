// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IProxyConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4013580468, 36868, 19926, 183, 216, 179, 229, 2, 244, 170, 208)]
  [ExclusiveTo(typeof (ProxyConfiguration))]
  internal interface IProxyConfiguration
  {
    IVectorView<Uri> ProxyUris { get; }

    bool CanConnectDirectly { get; }
  }
}
