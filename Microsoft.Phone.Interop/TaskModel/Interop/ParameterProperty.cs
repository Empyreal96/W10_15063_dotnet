// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ParameterProperty
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecuritySafeCritical]
  internal class ParameterProperty
  {
    public const int MAX_PROPERTY_NAMELEN = 260;
    public const int MAX_STRING_VALUELEN = 2048;
    private IntPtr m_handle;

    public ParameterProperty(IntPtr handle) => this.m_handle = handle;

    public ParameterPropertyValueType ValueType
    {
      get
      {
        ParameterPropertyValueType valueType = ParameterPropertyValueType.ValueType_Invalid;
        ParameterPropertyNativeMethods.GetValueType(this.m_handle, out valueType);
        return valueType;
      }
    }

    public string GetName()
    {
      StringBuilder stringBuilder = new StringBuilder(260);
      IntPtr handle = this.m_handle;
      StringBuilder pszName = stringBuilder;
      int capacity = pszName.Capacity;
      ParameterPropertyNativeMethods.GetName(handle, pszName, capacity);
      return stringBuilder.ToString();
    }

    public bool BoolValue
    {
      get
      {
        bool flag;
        ParameterPropertyNativeMethods.GetValueAsBool(this.m_handle, out flag);
        return flag;
      }
      set => ParameterPropertyNativeMethods.SetBoolValue(this.m_handle, value);
    }

    public int Int32Value
    {
      get
      {
        int num;
        ParameterPropertyNativeMethods.GetValueAsInt32(this.m_handle, out num);
        return num;
      }
      set => ParameterPropertyNativeMethods.SetInt32Value(this.m_handle, value);
    }

    public uint UInt32Value
    {
      get
      {
        uint num;
        ParameterPropertyNativeMethods.GetValueAsUInt32(this.m_handle, out num);
        return num;
      }
      set => ParameterPropertyNativeMethods.SetUInt32Value(this.m_handle, value);
    }

    public long Int64Value
    {
      get
      {
        long num;
        ParameterPropertyNativeMethods.GetValueAsInt64(this.m_handle, out num);
        return num;
      }
      set => ParameterPropertyNativeMethods.SetInt64Value(this.m_handle, value);
    }

    public ulong UInt64Value
    {
      get
      {
        ulong num;
        ParameterPropertyNativeMethods.GetValueAsUInt64(this.m_handle, out num);
        return num;
      }
      set => ParameterPropertyNativeMethods.SetUInt64Value(this.m_handle, value);
    }

    public string StringValue
    {
      get
      {
        StringBuilder stringBuilder = new StringBuilder(2048);
        IntPtr handle = this.m_handle;
        StringBuilder pszValue = stringBuilder;
        int capacity = pszValue.Capacity;
        ParameterPropertyNativeMethods.GetValueAsString(handle, pszValue, capacity);
        return stringBuilder.ToString();
      }
      set => ParameterPropertyNativeMethods.SetStringValue(this.m_handle, value);
    }

    public byte[] BufferValue
    {
      get
      {
        IntPtr pbData;
        int cbValue;
        ParameterPropertyNativeMethods.GetValueAsBuffer(this.m_handle, out pbData, out cbValue);
        if (cbValue <= 0)
          return (byte[]) null;
        byte[] destination = new byte[cbValue];
        Marshal.Copy(pbData, destination, 0, cbValue);
        return destination;
      }
    }
  }
}
