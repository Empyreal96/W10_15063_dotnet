// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.ParameterPropertyValueType
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

namespace Microsoft.Phone.TaskModel.Interop
{
  internal enum ParameterPropertyValueType
  {
    ValueType_Invalid = 0,
    ValueType_Bool = 1,
    ValueType_Int32 = 2,
    ValueType_UInt32 = 3,
    ValueType_Int64 = 32, // 0x00000020
    ValueType_UInt64 = 33, // 0x00000021
    ValueType_String = 64, // 0x00000040
    ValueType_Buffer = 65, // 0x00000041
    ValueType_Private = 66, // 0x00000042
    ValueType_PropertyBag = 128, // 0x00000080
  }
}
