﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdSystemIdentity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class OnlineIdSystemIdentity : IOnlineIdSystemIdentity
  {
    public extern OnlineIdServiceTicket Ticket { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }
  }
}