// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SECOLUMNINFO
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Runtime.InteropServices;

namespace System.Data.SqlServerCe
{
  [StructLayout(LayoutKind.Sequential)]
  internal class SECOLUMNINFO
  {
    public IntPtr pwszColumn = IntPtr.Zero;
    public uint cchMax;
    public SETYPE type;
    public uint ulSize;
    public uint bPrecision;
    public uint bScale;
    public long lSeed;
    public long lStep;
    public int fIsFixed;
    public int fIsNullable;
    public int fIsIdentity;
    public int fIsRowGuid;
    public int fIsWriteable;
    public int fIsSystem;
    public int fIsRowVersion;
    public long lIdentityMin;
    public long lIdentityMax;
    public long lIdentityNext;
    public int fMaybeNull;
    public IntPtr pwszBaseTable = IntPtr.Zero;
    public uint cchMaxBaseTable;
    public IntPtr pwszBaseColumn = IntPtr.Zero;
    public uint cchMaxBaseColumn;
    public uint dwCedbPropId;
    public IntPtr pwszDefaultExpr = IntPtr.Zero;
    public uint cchMaxDefaultExpr;
    public int fHasDefault;
    public int fIsExpression;
    public int fCompressed;
    public long lIdentityMinEx;
    public long lIdentityMaxEx;
    public int fUseExRange;
    public int fUseOverflowRange;

    static SECOLUMNINFO() => KillBitHelper.ThrowIfKillBitIsSet();
  }
}
