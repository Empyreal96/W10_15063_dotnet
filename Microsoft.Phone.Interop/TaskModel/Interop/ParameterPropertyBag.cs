// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ParameterPropertyBag
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecuritySafeCritical]
  internal class ParameterPropertyBag
  {
    private ParameterPropertyBagHandle m_handle;

    public ParameterPropertyBag() => ParameterPropertyBagNativeMethods.Create(out this.m_handle);

    public ParameterPropertyBag(byte[] buffer, uint size) => ParameterPropertyBagNativeMethods.Deserialize(buffer, size, out this.m_handle);

    public ParameterProperty CreateProperty(string propertyName)
    {
      IntPtr prop = IntPtr.Zero;
      ParameterPropertyBagNativeMethods.CreateProperty(this.m_handle, propertyName, out prop);
      return new ParameterProperty(prop);
    }

    public ParameterProperty GetProperty(string propertyName)
    {
      IntPtr zero = IntPtr.Zero;
      return new ParameterProperty(ParameterPropertyBagNativeMethods.GetProperty(this.m_handle, propertyName));
    }

    public uint SerializedSize => ParameterPropertyBagNativeMethods.GetSerializedSize(this.m_handle);

    public void Serialize(byte[] buffer, uint size) => ParameterPropertyBagNativeMethods.Serialize(this.m_handle, buffer, size);
  }
}
