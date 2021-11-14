// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemAuthenticatorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(2231662482, 63028, 16867, 150, 164, 81, 100, 233, 2, 199, 64)]
  [ExclusiveTo(typeof (OnlineIdSystemAuthenticator))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOnlineIdSystemAuthenticatorStatics
  {
    OnlineIdSystemAuthenticatorForUser Default { get; }

    OnlineIdSystemAuthenticatorForUser GetForUser(User user);
  }
}
