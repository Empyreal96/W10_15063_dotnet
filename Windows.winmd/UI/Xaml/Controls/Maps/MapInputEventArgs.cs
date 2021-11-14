// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapInputEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapInputEventArgs : DependencyObject, IMapInputEventArgs
  {
    [MethodImpl]
    public extern MapInputEventArgs();

    public extern Point Position { [MethodImpl] get; }

    public extern Geopoint Location { [MethodImpl] get; }
  }
}
