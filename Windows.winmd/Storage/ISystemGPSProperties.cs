// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemGPSProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemGPSProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3237244596, 49524, 18458, 188, 37, 146, 25, 134, 246, 166, 243)]
  internal interface ISystemGPSProperties
  {
    string LatitudeDecimal { get; }

    string LongitudeDecimal { get; }
  }
}
