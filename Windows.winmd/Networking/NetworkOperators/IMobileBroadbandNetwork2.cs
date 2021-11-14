// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetwork2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandNetwork))]
  [Guid(1515576098, 25335, 19421, 186, 29, 71, 116, 65, 150, 11, 160)]
  internal interface IMobileBroadbandNetwork2
  {
    [RemoteAsync]
    IAsyncOperation<bool> GetVoiceCallSupportAsync();

    IVectorView<MobileBroadbandUiccApp> RegistrationUiccApps { get; }
  }
}
