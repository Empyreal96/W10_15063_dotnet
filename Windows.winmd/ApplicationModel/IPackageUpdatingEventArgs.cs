// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageUpdatingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageUpdatingEventArgs))]
  [Guid(3447407144, 64884, 17470, 177, 20, 35, 230, 119, 176, 232, 111)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageUpdatingEventArgs
  {
    Guid ActivityId { get; }

    Package SourcePackage { get; }

    Package TargetPackage { get; }

    double Progress { get; }

    bool IsComplete { get; }

    HResult ErrorCode { get; }
  }
}
