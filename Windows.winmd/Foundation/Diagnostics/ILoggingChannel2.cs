// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingChannel2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(2672573683, 2988, 17829, 158, 51, 186, 243, 243, 162, 70, 165)]
  [ExclusiveTo(typeof (LoggingChannel))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoggingChannel2 : ILoggingChannel, IClosable, ILoggingTarget
  {
    Guid Id { get; }
  }
}
