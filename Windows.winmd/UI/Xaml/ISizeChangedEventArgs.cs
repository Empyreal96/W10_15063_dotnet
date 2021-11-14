// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISizeChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3576770144, 23745, 17057, 146, 12, 26, 244, 107, 226, 249, 134)]
  [ExclusiveTo(typeof (SizeChangedEventArgs))]
  internal interface ISizeChangedEventArgs
  {
    Size PreviousSize { get; }

    Size NewSize { get; }
  }
}
