// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILogFileGeneratedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LogFileGeneratedEventArgs))]
  [Guid(647927663, 3384, 19482, 181, 63, 179, 149, 216, 129, 223, 132)]
  internal interface ILogFileGeneratedEventArgs
  {
    StorageFile File { get; }
  }
}
