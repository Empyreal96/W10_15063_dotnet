// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class PackageId : IPackageId, IPackageIdWithMetadata
  {
    public extern string Name { [MethodImpl] get; }

    public extern PackageVersion Version { [MethodImpl] get; }

    public extern ProcessorArchitecture Architecture { [MethodImpl] get; }

    public extern string ResourceId { [MethodImpl] get; }

    public extern string Publisher { [MethodImpl] get; }

    public extern string PublisherId { [MethodImpl] get; }

    public extern string FullName { [MethodImpl] get; }

    public extern string FamilyName { [MethodImpl] get; }

    public extern string ProductId { [MethodImpl] get; }

    public extern string Author { [MethodImpl] get; }
  }
}
