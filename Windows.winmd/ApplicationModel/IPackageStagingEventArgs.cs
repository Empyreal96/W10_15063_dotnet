// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStagingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageStagingEventArgs))]
  [Guid(272721965, 21730, 20305, 184, 40, 158, 247, 4, 108, 33, 15)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageStagingEventArgs
  {
    Guid ActivityId { get; }

    Package Package { get; }

    double Progress { get; }

    bool IsComplete { get; }

    HResult ErrorCode { get; }
  }
}
