﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerRotationChangedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialControllerRotationChangedEventArgs))]
  [Guid(1029144300, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRadialControllerRotationChangedEventArgs2
  {
    bool IsButtonPressed { get; }

    SimpleHapticsController SimpleHapticsController { get; }
  }
}
