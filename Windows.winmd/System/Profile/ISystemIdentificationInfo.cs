// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISystemIdentificationInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (SystemIdentificationInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(207986301, 50114, 19763, 162, 223, 33, 188, 65, 145, 110, 179)]
  internal interface ISystemIdentificationInfo
  {
    IBuffer Id { get; }

    SystemIdentificationSource Source { get; }
  }
}
