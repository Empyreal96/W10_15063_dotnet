// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.FileUpdateStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FileUpdateStatus
  {
    Incomplete,
    Complete,
    UserInputNeeded,
    CurrentlyUnavailable,
    Failed,
    CompleteAndRenamed,
  }
}
