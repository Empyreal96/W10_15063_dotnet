// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyITADataGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (PlayReadyITADataGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(608463758, 4281, 17712, 178, 91, 144, 26, 128, 41, 169, 178)]
  internal interface IPlayReadyITADataGenerator
  {
    byte[] GenerateData(
      Guid guidCPSystemId,
      uint countOfStreams,
      IPropertySet configuration,
      PlayReadyITADataFormat format);
  }
}
