// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SECOLUMNATTRIB
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  [Flags]
  internal enum SECOLUMNATTRIB
  {
    NAME = 1,
    IDCOL = 2,
    IDRANGE = 4,
    WRITEABLE = 16, // 0x00000010
    NULLABLE = 32, // 0x00000020
    TYPE = 64, // 0x00000040
    IDENTITY = 128, // 0x00000080
    IDNEXT = 256, // 0x00000100
    SYSCOL = 512, // 0x00000200
    IDRANGE1 = 1024, // 0x00000400
    IDRANGE2 = 2048, // 0x00000800
  }
}
