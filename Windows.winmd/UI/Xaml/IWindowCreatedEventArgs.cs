// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindowCreatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(834081904, 65279, 18004, 175, 72, 155, 57, 138, 181, 119, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WindowCreatedEventArgs))]
  internal interface IWindowCreatedEventArgs
  {
    Window Window { get; }
  }
}
