// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.PhoneCallBlockedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneCallBlockedEventArgs : IPhoneCallBlockedEventArgs
  {
    public extern string PhoneNumber { [MethodImpl] get; }

    public extern PhoneCallBlockedReason Reason { [MethodImpl] get; }
  }
}
