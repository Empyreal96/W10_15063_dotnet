// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.ILocationInformation
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [Guid("76C23039-0D4B-4340-9A00-731CFE28D79E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ILocationInformation
  {
    [DispId(1610678272)]
    POSITIONINFO_STATUS PositionInfoStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    POSITIONINFO_COORDINATE PositionInfoCoordinate { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    POSITIONINFO_ACCURACY PositionInfoAccuracy { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    POSITIONINFO_SATELLITES PositionInfoSatellites { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678276)]
    ILocationVenueInformation PositionInfoVenue { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 28)] get; }
  }
}
