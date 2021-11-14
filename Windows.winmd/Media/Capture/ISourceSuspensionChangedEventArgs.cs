// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ISourceSuspensionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (SourceSuspensionChangedEventArgs))]
  [Guid(785283934, 54427, 17300, 188, 50, 249, 125, 108, 237, 236, 28)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface ISourceSuspensionChangedEventArgs
  {
    bool IsAudioSuspended { get; }

    bool IsVideoSuspended { get; }
  }
}
