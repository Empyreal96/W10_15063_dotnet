// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.IPMLiveTileJobInfo
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Shell
{
  [Guid("6009A81F-4710-4697-B5F6-2208F6057B8E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IPMLiveTileJobInfo
  {
    void get_ProductID(out Guid pProductID);

    void get_TileID([MarshalAs((UnmanagedType) 19)] out string pTileID);

    void get_NextSchedule();

    void set_NextSchedule();

    void get_StartSchedule();

    void set_StartSchedule();

    void get_IntervalDuration(out uint pIntervalDuration);

    void set_IntervalDuration(uint ulIntervalDuration);

    void get_RunForever(out bool IsRunForever);

    void set_RunForever(bool fRunForever);

    void get_MaxRunCount(out uint pMaxRunCount);

    void set_MaxRunCount(uint ulMaxRunCount);

    void get_RunCount(out uint pRunCount);

    void set_RunCount(uint ulRunCount);

    void get_RecurrenceType(out uint pRecurrenceType);

    void set_RecurrenceType(uint ulRecurrenceType);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int get_TileXML([MarshalAs(UnmanagedType.LPArray)] out byte[] pTileXml, out uint pcbTileXml);

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int set_TileXML([MarshalAs(UnmanagedType.LPArray), In] byte[] pTileXml, uint cbTileXml);

    void get_AttemptCount(out uint pAttemptCount);

    void set_AttemptCount(uint ulAttemptCount);

    void get_Uri([MarshalAs((UnmanagedType) 19)] out string pszUri);

    void set_Uri([MarshalAs((UnmanagedType) 19), In] string pszUri);

    void get_Uri2([MarshalAs((UnmanagedType) 19)] out string pszUri);

    void set_Uri2([MarshalAs((UnmanagedType) 19), In] string pszUri);
  }
}
