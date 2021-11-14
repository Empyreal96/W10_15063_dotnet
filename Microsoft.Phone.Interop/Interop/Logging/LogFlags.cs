// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Interop.Logging.LogFlags
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.ComponentModel;

namespace Microsoft.Phone.Interop.Logging
{
  [Flags]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal enum LogFlags : uint
  {
    None = 0,
    Health = 1,
    Ingestion = 2,
    Sqm = 4,
    MemoryStats = 256, // 0x00000100
    BatteryGaugeStats = 512, // 0x00000200
    BeginMarker = 65536, // 0x00010000
    EndMarker = 131072, // 0x00020000
    StreamEntryBegin = 262144, // 0x00040000
    StreamEntryAdd = 524288, // 0x00080000
    StreamEntryEnd = 1048576, // 0x00100000
    UInt32Blob = 16777216, // 0x01000000
    UInt64Blob = 33554432, // 0x02000000
    StringBlob = 67108864, // 0x04000000
  }
}
