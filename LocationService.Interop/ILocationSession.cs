// Decompiled with JetBrains decompiler
// Type: LocationServiceInterop.ILocationSession
// Assembly: LocationService.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 0F7FF74F-5B20-469A-BF3F-5B3C20DFBAEC
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\LOCATI~3.DLL

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LocationServiceInterop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("77746361-335B-4217-9F7E-96AE01E96958")]
  [ComImport]
  public interface ILocationSession
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StartSubscriberRequest();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StopSubscriberRequest();

    [DispId(1610678274)]
    string NotificationEventName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 19)] get; }

    [DispId(1610678275)]
    uint NotificationHandle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678276)]
    ILocationInformation CachedPositionInfo { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 28)] get; }

    [DispId(1610678277)]
    ILocationInformation NewPositionInfo { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs((UnmanagedType) 28)] get; }

    [DispId(1610678278)]
    LOCATIONREQUEST LOCATIONREQUEST { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678279)]
    uint SessionId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678280)]
    uint OwnerAcquireId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1610678281)]
    uint AttachedAcquireId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
