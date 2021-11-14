// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IEnclosureLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (EnclosureLocation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1110706727, 22544, 17820, 170, 187, 198, 94, 31, 129, 62, 207)]
  internal interface IEnclosureLocation
  {
    bool InDock { get; }

    bool InLid { get; }

    Panel Panel { get; }
  }
}
