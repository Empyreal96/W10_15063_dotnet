// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo : 
    IMicrosoftAccountMultiFactorUnregisteredAccountsAndSessionInfo
  {
    public extern IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { [MethodImpl] get; }

    public extern IVectorView<string> UnregisteredAccounts { [MethodImpl] get; }

    public extern MicrosoftAccountMultiFactorServiceResponse ServiceResponse { [MethodImpl] get; }
  }
}
