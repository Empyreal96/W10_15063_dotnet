// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.UserIdentity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UserIdentity : IUserIdentity
  {
    public extern IVectorView<OnlineIdServiceTicket> Tickets { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string SafeCustomerId { [MethodImpl] get; }

    public extern string SignInName { [MethodImpl] get; }

    public extern string FirstName { [MethodImpl] get; }

    public extern string LastName { [MethodImpl] get; }

    public extern bool IsBetaAccount { [MethodImpl] get; }

    public extern bool IsConfirmedPC { [MethodImpl] get; }
  }
}
