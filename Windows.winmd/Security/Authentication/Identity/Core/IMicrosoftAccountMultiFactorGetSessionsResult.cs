// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorGetSessionsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorGetSessionsResult))]
  [Guid(1310960032, 59898, 18810, 149, 222, 109, 87, 71, 191, 151, 76)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMicrosoftAccountMultiFactorGetSessionsResult
  {
    IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { get; }

    MicrosoftAccountMultiFactorServiceResponse ServiceResponse { get; }
  }
}
