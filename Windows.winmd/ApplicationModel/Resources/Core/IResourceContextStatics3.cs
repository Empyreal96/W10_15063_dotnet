// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceContextStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(550455596, 44815, 17675, 157, 166, 16, 109, 208, 194, 154, 57)]
  internal interface IResourceContextStatics3
  {
    [Overload("SetGlobalQualifierValueWithPersistence")]
    void SetGlobalQualifierValue(
      string key,
      string value,
      ResourceQualifierPersistence persistence);
  }
}
