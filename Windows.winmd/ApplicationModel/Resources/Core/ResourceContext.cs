// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IResourceContextStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceContextStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceContextStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResourceContext : IResourceContext
  {
    [MethodImpl]
    public extern ResourceContext();

    public extern IObservableMap<string, string> QualifierValues { [MethodImpl] get; }

    [Overload("Reset")]
    [MethodImpl]
    public extern void Reset();

    [Overload("ResetQualifierValues")]
    [MethodImpl]
    public extern void Reset(IIterable<string> qualifierNames);

    [MethodImpl]
    public extern void OverrideToMatch(IIterable<ResourceQualifier> result);

    [MethodImpl]
    public extern ResourceContext Clone();

    public extern IVectorView<string> Languages { [MethodImpl] get; [MethodImpl] set; }

    [Overload("SetGlobalQualifierValueWithPersistence")]
    [MethodImpl]
    public static extern void SetGlobalQualifierValue(
      string key,
      string value,
      ResourceQualifierPersistence persistence);

    [MethodImpl]
    public static extern ResourceContext GetForCurrentView();

    [Overload("SetGlobalQualifierValue")]
    [MethodImpl]
    public static extern void SetGlobalQualifierValue(string key, string value);

    [Overload("ResetGlobalQualifierValues")]
    [MethodImpl]
    public static extern void ResetGlobalQualifierValues();

    [Overload("ResetGlobalQualifierValuesForSpecifiedQualifiers")]
    [MethodImpl]
    public static extern void ResetGlobalQualifierValues(IIterable<string> qualifierNames);

    [MethodImpl]
    public static extern ResourceContext GetForViewIndependentUse();

    [Deprecated("CreateMatchingContext may be altered or unavailable for releases after Windows 8.1. Instead, use ResourceContext.GetForCurrentView.OverrideToMatch.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern ResourceContext CreateMatchingContext(
      IIterable<ResourceQualifier> result);
  }
}
