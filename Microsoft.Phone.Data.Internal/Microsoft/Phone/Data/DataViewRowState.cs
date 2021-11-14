// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.DataViewRowState
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;

namespace Microsoft.Phone.Data
{
  [Flags]
  public enum DataViewRowState
  {
    None = 0,
    Unchanged = 2,
    Added = 4,
    Deleted = 8,
    ModifiedCurrent = 16, // 0x00000010
    ModifiedOriginal = 32, // 0x00000020
    OriginalRows = ModifiedOriginal | Deleted | Unchanged, // 0x0000002A
    CurrentRows = ModifiedCurrent | Added | Unchanged, // 0x00000016
  }
}
