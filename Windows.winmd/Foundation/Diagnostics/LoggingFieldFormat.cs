// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingFieldFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LoggingFieldFormat
  {
    Default,
    Hidden,
    String,
    Boolean,
    Hexadecimal,
    ProcessId,
    ThreadId,
    Port,
    Ipv4Address,
    Ipv6Address,
    SocketAddress,
    Xml,
    Json,
    Win32Error,
    NTStatus,
    HResult,
    FileTime,
    Signed,
    Unsigned,
  }
}
