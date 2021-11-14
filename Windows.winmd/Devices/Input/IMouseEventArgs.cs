// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IMouseEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (MouseEventArgs))]
  [Guid(4129663581, 9044, 19655, 146, 48, 150, 148, 28, 150, 159, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMouseEventArgs
  {
    MouseDelta MouseDelta { get; }
  }
}
