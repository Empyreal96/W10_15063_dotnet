// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(450586206, 14279, 18320, 153, 128, 221, 122, 231, 78, 139, 178)]
  [ExclusiveTo(typeof (PackageId))]
  internal interface IPackageId
  {
    string Name { get; }

    PackageVersion Version { get; }

    ProcessorArchitecture Architecture { get; }

    string ResourceId { get; }

    string Publisher { get; }

    string PublisherId { get; }

    string FullName { get; }

    string FamilyName { get; }
  }
}
