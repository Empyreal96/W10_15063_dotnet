﻿// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.SmsFilterMessageReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsFilterMessageReceivedEventArgs : ISmsFilterMessageReceivedEventArgs
  {
    public extern string SenderPhoneNumber { [MethodImpl] get; }

    public extern string Body { [MethodImpl] get; }

    public extern SmsFilterAction Action { [MethodImpl] get; [MethodImpl] set; }
  }
}
