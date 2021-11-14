// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Net.NetworkInformation.ICellularPacketData
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Net.NetworkInformation
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("a4ce2e7c-134e-4120-8a3f-66c3630a1e2c")]
  [ComImport]
  internal interface ICellularPacketData
  {
    void SetInternetApnSettings(
      [MarshalAs(UnmanagedType.LPArray), In] byte[] iccid,
      [In] uint cbIccid,
      [In] uint slotIndex,
      [In] ref CellularInternetApnSettings settings);

    void GetInternetApnSettings(
      [MarshalAs(UnmanagedType.LPArray), In] byte[] iccid,
      [In] uint cbIccid,
      [In] uint slotIndex,
      out CellularInternetApnSettings settings);

    void DeleteInternetApnSettings([MarshalAs(UnmanagedType.LPArray), In] byte[] iccid, [In] uint cbIccid, [In] uint slotIndex);

    void SetMmsApnSettings(
      [MarshalAs(UnmanagedType.LPArray), In] byte[] iccid,
      [In] uint cbIccid,
      [In] uint slotIndex,
      [In] ref CellularMmsApnSettings settings);

    void GetMmsApnSettings(
      [MarshalAs(UnmanagedType.LPArray), In] byte[] iccid,
      [In] uint cbIccid,
      [In] uint slotIndex,
      out CellularMmsApnSettings settings);

    void DeleteMmsApnSettings([MarshalAs(UnmanagedType.LPArray), In] byte[] iccid, [In] uint cbIccid, [In] uint slotIndex);

    void SetCellularDataRoamingState([In] CellularDataRoamingSetting settings);

    void GetCellularDataRoamingState(out CellularDataRoamingSetting settings);

    void SetCellularDataEnabledState([In] bool enabled);

    void GetCellularDataEnabledState(out bool enabled);
  }
}
