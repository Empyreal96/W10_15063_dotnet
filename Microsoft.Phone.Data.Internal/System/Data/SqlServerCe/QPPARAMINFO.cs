// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.QPPARAMINFO
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Runtime.InteropServices;

namespace System.Data.SqlServerCe
{
  [StructLayout(LayoutKind.Sequential)]
  internal class QPPARAMINFO
  {
    public IntPtr pwszParam = IntPtr.Zero;
    public uint cchMax;
    public uint iOrdinal;
    public QPPARAMTYPE paramType;
    public SETYPE type;
    public uint ulSize;
    public byte bPrecision;
    public byte bScale;
    public short padding;
    public int fIsTyped;

    static QPPARAMINFO() => KillBitHelper.ThrowIfKillBitIsSet();
  }
}
