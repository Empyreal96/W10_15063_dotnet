﻿// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.DBTIMESTAMP
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace System.Data.SqlServerCe
{
  internal struct DBTIMESTAMP
  {
    public short year;
    public ushort month;
    public ushort day;
    public ushort hour;
    public ushort minute;
    public ushort second;
    public uint fraction;
  }
}