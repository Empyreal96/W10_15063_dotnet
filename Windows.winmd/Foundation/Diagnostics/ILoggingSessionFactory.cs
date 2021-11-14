// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingSessionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ExclusiveTo(typeof (LoggingSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1318289125, 22781, 17888, 140, 47, 161, 50, 239, 249, 92, 30)]
  internal interface ILoggingSessionFactory
  {
    LoggingSession Create(string name);
  }
}
