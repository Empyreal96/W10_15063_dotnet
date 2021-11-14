// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IQueryOptionsWithProviderFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (QueryOptions))]
  [Guid(1537019942, 5572, 17629, 184, 154, 71, 165, 155, 125, 124, 79)]
  internal interface IQueryOptionsWithProviderFilter
  {
    IVector<string> StorageProviderIdFilter { get; }
  }
}
