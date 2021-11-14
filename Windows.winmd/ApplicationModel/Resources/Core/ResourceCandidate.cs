// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceCandidate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceCandidate : IResourceCandidate, IResourceCandidate2
  {
    public extern IVectorView<ResourceQualifier> Qualifiers { [MethodImpl] get; }

    public extern bool IsMatch { [MethodImpl] get; }

    public extern bool IsMatchAsDefault { [MethodImpl] get; }

    public extern bool IsDefault { [MethodImpl] get; }

    public extern string ValueAsString { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetValueAsFileAsync();

    [MethodImpl]
    public extern string GetQualifierValue(string qualifierName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetValueAsStreamAsync();
  }
}
