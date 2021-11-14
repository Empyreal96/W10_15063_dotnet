// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.SETABLEINFO
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Runtime.InteropServices;

namespace System.Data.SqlServerCe
{
  [StructLayout(LayoutKind.Sequential)]
  internal class SETABLEINFO
  {
    public IntPtr pwszTable = IntPtr.Zero;
    public uint cchMax;
    public bool fIsSystem;
    public bool fReadOnly;
    public ulong uhVersion;
    public bool fTemporary;
    public bool fOrdered;
    public long lNextIdentity;
    public bool fIdentityOverflow;
    public ushort wTracking;
    public int lTableNick;
    public uint dwCedbType;
    public int hBookmark;
    public uint cPages;
    public uint cLvPages;
    public uint dwGrantedOps;
    public bool fHasDefaults;
    public bool fCompressed;
    public uint cStatMods;

    static SETABLEINFO() => KillBitHelper.ThrowIfKillBitIsSet();
  }
}
