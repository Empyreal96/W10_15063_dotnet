// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IInputPane2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (InputPane))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2322284326, 28816, 18323, 148, 76, 195, 242, 205, 226, 98, 118)]
  internal interface IInputPane2
  {
    bool TryShow();

    bool TryHide();
  }
}
