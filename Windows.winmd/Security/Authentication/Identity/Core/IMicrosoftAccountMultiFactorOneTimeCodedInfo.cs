// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorOneTimeCodedInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [Guid(2193237579, 55420, 18024, 169, 118, 64, 207, 174, 84, 125, 8)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorOneTimeCodedInfo))]
  internal interface IMicrosoftAccountMultiFactorOneTimeCodedInfo
  {
    string Code { get; }

    TimeSpan TimeInterval { get; }

    TimeSpan TimeToLive { get; }

    MicrosoftAccountMultiFactorServiceResponse ServiceResponse { get; }
  }
}
