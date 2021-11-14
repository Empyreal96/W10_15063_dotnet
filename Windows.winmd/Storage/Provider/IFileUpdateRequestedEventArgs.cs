// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.IFileUpdateRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Guid(2064290626, 14597, 17293, 170, 239, 120, 174, 38, 95, 141, 210)]
  [ExclusiveTo(typeof (FileUpdateRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileUpdateRequestedEventArgs
  {
    FileUpdateRequest Request { get; }
  }
}
