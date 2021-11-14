// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IKeyboardCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(977247062, 26520, 19388, 131, 62, 15, 52, 177, 124, 101, 255)]
  [ExclusiveTo(typeof (KeyboardCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyboardCapabilities
  {
    int KeyboardPresent { get; }
  }
}
