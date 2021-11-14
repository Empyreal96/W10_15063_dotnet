// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingActivity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingActivity))]
  [Guid(3154323777, 46950, 19637, 152, 72, 151, 172, 107, 166, 214, 12)]
  internal interface ILoggingActivity : IClosable
  {
    string Name { get; }

    Guid Id { get; }
  }
}
