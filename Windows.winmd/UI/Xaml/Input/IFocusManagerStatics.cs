// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (FocusManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(516739878, 33154, 17538, 130, 106, 9, 24, 233, 237, 154, 247)]
  [WebHostHidden]
  internal interface IFocusManagerStatics
  {
    object GetFocusedElement();
  }
}
