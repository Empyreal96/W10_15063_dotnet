// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  public sealed class SystemMediaTransportControlsPropertyChangedEventArgs : 
    ISystemMediaTransportControlsPropertyChangedEventArgs
  {
    public extern SystemMediaTransportControlsProperty Property { [MethodImpl] get; }
  }
}
