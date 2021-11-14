// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.ITargetFileRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (TargetFileRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1119695701, 32648, 18315, 142, 129, 105, 11, 32, 52, 6, 120)]
  internal interface ITargetFileRequest
  {
    IStorageFile TargetFile { get; set; }

    TargetFileRequestDeferral GetDeferral();
  }
}
