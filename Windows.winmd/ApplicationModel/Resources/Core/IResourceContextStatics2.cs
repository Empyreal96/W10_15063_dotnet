// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceContextStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceContext))]
  [Guid(1106727663, 4783, 16825, 171, 54, 177, 235, 75, 81, 36, 96)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceContextStatics2
  {
    ResourceContext GetForCurrentView();

    [Overload("SetGlobalQualifierValue")]
    void SetGlobalQualifierValue(string key, string value);

    [Overload("ResetGlobalQualifierValues")]
    void ResetGlobalQualifierValues();

    [Overload("ResetGlobalQualifierValuesForSpecifiedQualifiers")]
    void ResetGlobalQualifierValues(IIterable<string> qualifierNames);

    ResourceContext GetForViewIndependentUse();
  }
}
