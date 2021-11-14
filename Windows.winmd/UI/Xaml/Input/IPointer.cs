// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IPointer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (Pointer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1592325023, 29821, 16753, 144, 230, 205, 55, 169, 223, 251, 17)]
  internal interface IPointer
  {
    uint PointerId { get; }

    PointerDeviceType PointerDeviceType { get; }

    bool IsInContact { get; }

    bool IsInRange { get; }
  }
}
