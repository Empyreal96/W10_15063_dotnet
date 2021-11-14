// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePickerAppearance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class DevicePickerAppearance : IDevicePickerAppearance
  {
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color AccentColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color SelectedForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color SelectedBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern Color SelectedAccentColor { [MethodImpl] get; [MethodImpl] set; }
  }
}
