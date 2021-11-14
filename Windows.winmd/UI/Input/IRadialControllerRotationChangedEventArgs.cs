// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerRotationChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialControllerRotationChangedEventArgs))]
  [Guid(543859765, 58961, 4581, 191, 98, 44, 39, 215, 64, 78, 133)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRadialControllerRotationChangedEventArgs
  {
    double RotationDeltaInDegrees { get; }

    RadialControllerScreenContact Contact { get; }
  }
}
