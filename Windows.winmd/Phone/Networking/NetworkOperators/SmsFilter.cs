// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.SmsFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [Static(typeof (ISmsFilterStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class SmsFilter
  {
    [MethodImpl]
    public static extern void EnableFiltering(bool enableSmsFiltering);

    public static extern SmsFilterStatus Status { [MethodImpl] get; }

    public static extern event EventHandler<SmsFilterMessageReceivedEventArgs> SmsMessageReceived;

    public static extern event EventHandler<object> StatusChanged;
  }
}
