// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IEnclosureLocation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (EnclosureLocation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(679844187, 57469, 18525, 138, 158, 189, 242, 154, 239, 79, 102)]
  internal interface IEnclosureLocation2 : IEnclosureLocation
  {
    uint RotationAngleInDegreesClockwise { get; }
  }
}
