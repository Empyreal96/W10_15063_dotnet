// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SETABLEATTRIBS
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  [Flags]
  internal enum SETABLEATTRIBS
  {
    TRACKING = 1,
    GRANTEDOPS = 2,
    ISSYSTEM = 4,
    EDBTYPE = 8,
    ISREADONLY = 16, // 0x00000010
    VALIDATTRIBS = ISREADONLY | EDBTYPE | ISSYSTEM | GRANTEDOPS | TRACKING, // 0x0000001F
  }
}
