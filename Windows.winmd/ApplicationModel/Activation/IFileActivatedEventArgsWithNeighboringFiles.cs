// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithNeighboringFiles
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Search;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1127981476, 57826, 18685, 183, 252, 181, 214, 238, 230, 80, 51)]
  public interface IFileActivatedEventArgsWithNeighboringFiles : 
    IFileActivatedEventArgs,
    IActivatedEventArgs
  {
    StorageFileQueryResult NeighboringFilesQuery { get; }
  }
}
