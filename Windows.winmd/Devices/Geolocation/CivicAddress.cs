// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.CivicAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CivicAddress : ICivicAddress
  {
    public extern string Country { [MethodImpl] get; }

    public extern string State { [MethodImpl] get; }

    public extern string City { [MethodImpl] get; }

    public extern string PostalCode { [MethodImpl] get; }

    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
