// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1067663217, 11731, 19437, 174, 73, 247, 20, 142, 99, 231, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayReadyStatics))]
  internal interface IPlayReadyStatics3 : IPlayReadyStatics2, IPlayReadyStatics
  {
    Guid SecureStopServiceRequestType { get; }

    bool CheckSupportedHardware(PlayReadyHardwareDRMFeatures hwdrmFeature);
  }
}
