// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IFileLoggingSessionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(4003499470, 33863, 19882, 145, 51, 18, 235, 70, 246, 151, 212)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileLoggingSession))]
  internal interface IFileLoggingSessionFactory
  {
    FileLoggingSession Create(string name);
  }
}
