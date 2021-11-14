// Decompiled with JetBrains decompiler
// Type: Windows.System.Display.IDisplayRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Display
{
  [ExclusiveTo(typeof (DisplayRequest))]
  [Guid(3849527364, 62623, 19296, 141, 212, 94, 126, 58, 99, 42, 192)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDisplayRequest
  {
    void RequestActive();

    void RequestRelease();
  }
}
