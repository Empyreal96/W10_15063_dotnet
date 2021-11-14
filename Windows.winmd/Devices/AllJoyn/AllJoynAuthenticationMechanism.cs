// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAuthenticationMechanism
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AllJoynAuthenticationMechanism
  {
    None,
    [Deprecated("SrpAnonymous is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] SrpAnonymous,
    [Deprecated("SrpLogon is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] SrpLogon,
    EcdheNull,
    [Deprecated("EcdhePsk is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] EcdhePsk,
    EcdheEcdsa,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EcdheSpeke,
  }
}
