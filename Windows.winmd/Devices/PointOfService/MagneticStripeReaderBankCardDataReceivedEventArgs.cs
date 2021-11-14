// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderBankCardDataReceivedEventArgs : 
    IMagneticStripeReaderBankCardDataReceivedEventArgs
  {
    public extern MagneticStripeReaderReport Report { [MethodImpl] get; }

    public extern string AccountNumber { [MethodImpl] get; }

    public extern string ExpirationDate { [MethodImpl] get; }

    public extern string ServiceCode { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string FirstName { [MethodImpl] get; }

    public extern string MiddleInitial { [MethodImpl] get; }

    public extern string Surname { [MethodImpl] get; }

    public extern string Suffix { [MethodImpl] get; }
  }
}
