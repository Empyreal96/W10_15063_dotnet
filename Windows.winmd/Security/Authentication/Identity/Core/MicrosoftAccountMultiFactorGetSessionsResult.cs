// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.MicrosoftAccountMultiFactorGetSessionsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MicrosoftAccountMultiFactorGetSessionsResult : 
    IMicrosoftAccountMultiFactorGetSessionsResult
  {
    public extern IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { [MethodImpl] get; }

    public extern MicrosoftAccountMultiFactorServiceResponse ServiceResponse { [MethodImpl] get; }
  }
}
