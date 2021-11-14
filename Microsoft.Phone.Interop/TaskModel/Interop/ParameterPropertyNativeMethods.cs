// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ParameterPropertyNativeMethods
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecurityCritical]
  internal class ParameterPropertyNativeMethods
  {
    [DllImport("emclient.dll", EntryPoint = "Property_GetName", CharSet = CharSet.Unicode, PreserveSig = false)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    public static extern void GetName([In] IntPtr hProperty, [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszName, int cchName);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueType", PreserveSig = false)]
    public static extern void GetValueType(
      [In] IntPtr hProperty,
      out ParameterPropertyValueType valueType);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsBool", PreserveSig = false)]
    public static extern void GetValueAsBool([In] IntPtr hProperty, out bool value);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsInt32", PreserveSig = false)]
    public static extern void GetValueAsInt32([In] IntPtr hProperty, out int value);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsUInt32", PreserveSig = false)]
    public static extern void GetValueAsUInt32([In] IntPtr hProperty, out uint value);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsInt64", PreserveSig = false)]
    public static extern void GetValueAsInt64([In] IntPtr hProperty, out long value);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsUInt64", PreserveSig = false)]
    public static extern void GetValueAsUInt64([In] IntPtr hProperty, out ulong value);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsString", PreserveSig = false)]
    public static extern void GetValueAsString(
      [In] IntPtr hProperty,
      [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder pszValue,
      int cchValue);

    [DllImport("emclient.dll", EntryPoint = "Property_GetValueAsBuffer", PreserveSig = false)]
    public static extern void GetValueAsBuffer(
      [In] IntPtr hProperty,
      out IntPtr pbData,
      out int cbValue);

    [DllImport("emclient.dll", EntryPoint = "Property_SetBoolValue", PreserveSig = false)]
    public static extern void SetBoolValue([In] IntPtr hProperty, bool value);

    [DllImport("emclient.dll", EntryPoint = "Property_SetInt32Value", PreserveSig = false)]
    public static extern void SetInt32Value([In] IntPtr hProperty, int value);

    [DllImport("emclient.dll", EntryPoint = "Property_SetUInt32Value", PreserveSig = false)]
    public static extern void SetUInt32Value([In] IntPtr hProperty, uint value);

    [DllImport("emclient.dll", EntryPoint = "Property_SetInt64Value", PreserveSig = false)]
    public static extern void SetInt64Value([In] IntPtr hProperty, long value);

    [DllImport("emclient.dll", EntryPoint = "Property_SetUInt64Value", PreserveSig = false)]
    public static extern void SetUInt64Value([In] IntPtr hProperty, ulong value);

    [DllImport("emclient.dll", EntryPoint = "Property_SetStringValue", PreserveSig = false)]
    public static extern void SetStringValue([In] IntPtr hProperty, [MarshalAs(UnmanagedType.LPWStr), In] string value);
  }
}
