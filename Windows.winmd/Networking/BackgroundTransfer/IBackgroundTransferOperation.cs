// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(3738200134, 37066, 17659, 143, 177, 18, 65, 84, 192, 213, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBackgroundTransferOperation
  {
    Guid Guid { get; }

    global::Windows.Foundation.Uri RequestedUri { get; }

    string Method { get; }

    string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    BackgroundTransferCostPolicy CostPolicy { get; set; }

    IInputStream GetResultStreamAt(ulong position);

    ResponseInformation GetResponseInformation();
  }
}
