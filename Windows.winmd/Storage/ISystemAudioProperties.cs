// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemAudioProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemAudioProperties))]
  [Guid(1066350775, 12428, 18401, 146, 77, 134, 69, 52, 142, 93, 183)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemAudioProperties
  {
    string EncodingBitrate { get; }
  }
}
