// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderCardTypes
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMagneticStripeReaderCardTypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class MagneticStripeReaderCardTypes
  {
    public static extern uint Unknown { [MethodImpl] get; }

    public static extern uint Bank { [MethodImpl] get; }

    public static extern uint Aamva { [MethodImpl] get; }

    public static extern uint ExtendedBase { [MethodImpl] get; }
  }
}
