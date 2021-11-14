// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(799158091, 28798, 19239, 173, 13, 208, 216, 205, 70, 143, 210)]
  [ExclusiveTo(typeof (ResourceContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceContext
  {
    IObservableMap<string, string> QualifierValues { get; }

    [Overload("Reset")]
    void Reset();

    [Overload("ResetQualifierValues")]
    void Reset(IIterable<string> qualifierNames);

    void OverrideToMatch(IIterable<ResourceQualifier> result);

    ResourceContext Clone();

    IVectorView<string> Languages { get; set; }
  }
}
