// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.ILocationVenueInformation
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [Guid("A8C20AC3-4F66-423A-A1AE-396142818006")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ILocationVenueInformation
  {
    [DispId(1610678272)]
    string VenueProvider { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 19)] get; }

    [DispId(1610678273)]
    string VenueId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 19)] get; }

    [DispId(1610678274)]
    string FloorId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 19)] get; }
  }
}
