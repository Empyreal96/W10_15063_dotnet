// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebProviderError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebProviderErrorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebProviderError : IWebProviderError
  {
    [MethodImpl]
    public extern WebProviderError(uint errorCode, string errorMessage);

    public extern uint ErrorCode { [MethodImpl] get; }

    public extern string ErrorMessage { [MethodImpl] get; }

    public extern IMap<string, string> Properties { [MethodImpl] get; }
  }
}
