// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(286230575, 7173, 18007, 161, 142, 71, 201, 182, 159, 7, 171)]
  public interface IDefaultAudioDeviceChangedEventArgs
  {
    string Id { get; }

    AudioDeviceRole Role { get; }
  }
}
