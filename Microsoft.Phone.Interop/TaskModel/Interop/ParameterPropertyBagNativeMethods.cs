// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ParameterPropertyBagNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecurityCritical]
  internal class ParameterPropertyBagNativeMethods
  {
    [DllImport("emclient.dll", EntryPoint = "PropBag_Create", PreserveSig = false)]
    public static extern void Create(out ParameterPropertyBagHandle hPropBag);

    [DllImport("emclient.dll", EntryPoint = "PropBag_Release")]
    public static extern void Release([In] IntPtr hPropBag);

    [DllImport("emclient.dll", EntryPoint = "PropBag_CreateProperty", PreserveSig = false)]
    public static extern void CreateProperty(
      [In] ParameterPropertyBagHandle hPropBag,
      [MarshalAs(UnmanagedType.LPWStr), In] string propertyName,
      out IntPtr prop);

    [DllImport("emclient.dll", EntryPoint = "PropBag_GetProperty")]
    public static extern IntPtr GetProperty(
      [In] ParameterPropertyBagHandle hPropBag,
      [MarshalAs(UnmanagedType.LPWStr), In] string propertyName);

    [DllImport("emclient.dll", EntryPoint = "PropBag_GetSerializedSize")]
    public static extern uint GetSerializedSize([In] ParameterPropertyBagHandle hPropBag);

    [DllImport("emclient.dll", EntryPoint = "PropBag_Serialize", PreserveSig = false)]
    public static extern void Serialize(
      [In] ParameterPropertyBagHandle hPropBag,
      byte[] buffer,
      uint size);

    [DllImport("emclient.dll", EntryPoint = "PropBag_Deserialize", PreserveSig = false)]
    public static extern void Deserialize(
      byte[] buffer,
      uint size,
      out ParameterPropertyBagHandle hPropBag);
  }
}
