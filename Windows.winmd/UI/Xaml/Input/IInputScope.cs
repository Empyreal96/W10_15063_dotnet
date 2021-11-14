// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInputScope
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1544521203, 63960, 16928, 182, 102, 4, 93, 7, 77, 155, 250)]
  [ExclusiveTo(typeof (InputScope))]
  internal interface IInputScope
  {
    IVector<InputScopeName> Names { get; }
  }
}
