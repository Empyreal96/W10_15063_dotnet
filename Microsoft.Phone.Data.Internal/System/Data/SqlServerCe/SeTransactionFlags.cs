// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SeTransactionFlags
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  [Flags]
  internal enum SeTransactionFlags
  {
    NOFLAGS = 0,
    SYSTEM = 1,
    GENERATEIDENTITY = 2,
    GENERATEROWGUID = 4,
    TRACK = 8,
    REPLACECOLUMN = 16, // 0x00000010
    DISABLETRIGGERS = 32, // 0x00000020
    COMPRESSEDLVSTREAM = 64, // 0x00000040
    VALIDFLAGS = COMPRESSEDLVSTREAM | DISABLETRIGGERS | REPLACECOLUMN | TRACK | GENERATEROWGUID | GENERATEIDENTITY | SYSTEM, // 0x0000007F
  }
}
