// Decompiled with JetBrains decompiler
// Type: Windows.Media.IAudioBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(890722343, 29259, 19562, 177, 48, 246, 83, 127, 154, 224, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioBuffer))]
  internal interface IAudioBuffer : IMemoryBuffer, IClosable
  {
    uint Capacity { get; }

    uint Length { get; set; }
  }
}
