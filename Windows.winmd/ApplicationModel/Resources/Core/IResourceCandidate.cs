// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceCandidate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceCandidate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2941388761, 50227, 18276, 179, 253, 143, 166, 191, 188, 186, 220)]
  internal interface IResourceCandidate
  {
    IVectorView<ResourceQualifier> Qualifiers { get; }

    bool IsMatch { get; }

    bool IsMatchAsDefault { get; }

    bool IsDefault { get; }

    string ValueAsString { get; }

    [RemoteAsync]
    IAsyncOperation<StorageFile> GetValueAsFileAsync();

    string GetQualifierValue(string qualifierName);
  }
}
