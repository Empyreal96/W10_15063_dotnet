// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SORTFLAGS
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  [Flags]
  internal enum SORTFLAGS
  {
    NORM_IGNORECASE = 1,
    NORM_IGNOREKANATYPE = 65536, // 0x00010000
    NORM_IGNOREWIDTH = 131072, // 0x00020000
  }
}
