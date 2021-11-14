// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IUserIdentity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(558291405, 1858, 19427, 138, 28, 124, 122, 230, 121, 170, 136)]
  [ExclusiveTo(typeof (UserIdentity))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUserIdentity
  {
    IVectorView<OnlineIdServiceTicket> Tickets { get; }

    string Id { get; }

    string SafeCustomerId { get; }

    string SignInName { get; }

    string FirstName { get; }

    string LastName { get; }

    bool IsBetaAccount { get; }

    bool IsConfirmedPC { get; }
  }
}
