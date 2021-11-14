// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceCandidate2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceCandidate))]
  [Guid(1776661608, 63228, 16403, 170, 162, 213, 63, 23, 87, 211, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceCandidate2
  {
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> GetValueAsStreamAsync();
  }
}
