// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageContentGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPackageContentGroupStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageContentGroup : IPackageContentGroup
  {
    public extern Package Package { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern PackageContentGroupState State { [MethodImpl] get; }

    public extern bool IsRequired { [MethodImpl] get; }

    public static extern string RequiredGroupName { [MethodImpl] get; }
  }
}
