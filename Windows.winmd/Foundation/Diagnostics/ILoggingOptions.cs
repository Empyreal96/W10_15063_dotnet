// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2428270672, 402, 20317, 172, 38, 0, 106, 218, 202, 18, 216)]
  [ExclusiveTo(typeof (LoggingOptions))]
  internal interface ILoggingOptions
  {
    long Keywords { get; set; }

    int Tags { get; set; }

    short Task { get; set; }

    LoggingOpcode Opcode { get; set; }

    Guid ActivityId { get; set; }

    Guid RelatedActivityId { get; set; }
  }
}
