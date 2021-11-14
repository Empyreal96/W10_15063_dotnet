// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Logger
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Phone.Logging;

namespace Microsoft.Xna.Framework
{
  internal static class Logger
  {
    public static void LogEvent(LoggingEvent eventID, string message) => Microsoft.Phone.Logging.Logger.YLogEvent(2147483652U, (uint) eventID, LogFlags.Health | LogFlags.MemoryStats, message);

    public static void BeginLogEvent(LoggingEvent eventID, string message) => Microsoft.Phone.Logging.Logger.YLogEvent(2147483652U, (uint) eventID, LogFlags.Health | LogFlags.MemoryStats | LogFlags.BeginMarker, message);

    public static void EndLogEvent(LoggingEvent eventID, string message) => Microsoft.Phone.Logging.Logger.YLogEvent(2147483652U, (uint) eventID, LogFlags.Health | LogFlags.MemoryStats | LogFlags.EndMarker, message);
  }
}
