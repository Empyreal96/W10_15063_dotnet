// Decompiled with JetBrains decompiler
// Type: System.Data.SqlServerCe.KillBitHelper
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System.Security;

namespace System.Data.SqlServerCe
{
  internal static class KillBitHelper
  {
    private static readonly string FwdLink = "http://go.microsoft.com/fwlink/?LinkID=196096&clcid=0x409";
    private static bool isKillBitted = KillBitHelper.GetKillBit();

    [SecurityCritical]
    static KillBitHelper() => KillBitHelper.ThrowIfKillBitIsSet();

    internal static void ThrowIfKillBitIsSet()
    {
      if (KillBitHelper.isKillBitted)
        throw new SecurityException(string.Format(Res.GetString("SQLCE_KillBitted"), (object) "3.5.5722.1", (object) KillBitHelper.FwdLink));
    }

    [SecurityCritical]
    public static bool GetKillBit() => false;
  }
}
