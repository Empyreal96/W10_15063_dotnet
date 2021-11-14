// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageContentGroupStagingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1031520894, 28455, 17516, 152, 110, 212, 115, 61, 77, 145, 19)]
  [ExclusiveTo(typeof (PackageContentGroupStagingEventArgs))]
  internal interface IPackageContentGroupStagingEventArgs
  {
    Guid ActivityId { get; }

    Package Package { get; }

    double Progress { get; }

    bool IsComplete { get; }

    HResult ErrorCode { get; }

    string ContentGroupName { get; }

    bool IsContentGroupRequired { get; }
  }
}
