// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.DbColumnFlags
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  [Flags]
  internal enum DbColumnFlags
  {
    ISBOOKMARK = 1,
    MAYDEFER = 2,
    WRITE = 4,
    WRITEUNKNOWN = 8,
    ISFIXEDLENGTH = 16, // 0x00000010
    ISNULLABLE = 32, // 0x00000020
    MAYBENULL = 64, // 0x00000040
    ISLONG = 128, // 0x00000080
    ISROWID = 256, // 0x00000100
    ISROWVER = 512, // 0x00000200
    CACHEDEFERRED = 4096, // 0x00001000
  }
}
