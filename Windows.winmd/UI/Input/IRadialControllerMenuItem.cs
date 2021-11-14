// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenuItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialControllerMenuItem))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3356477837, 44299, 19612, 143, 47, 19, 106, 35, 115, 166, 186)]
  internal interface IRadialControllerMenuItem
  {
    string DisplayText { get; }

    object Tag { [return: Variant] get; [param: Variant] set; }

    event TypedEventHandler<RadialControllerMenuItem, object> Invoked;
  }
}
