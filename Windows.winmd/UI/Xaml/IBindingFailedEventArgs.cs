// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IBindingFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (BindingFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(851562515, 19901, 17517, 187, 184, 13, 227, 80, 72, 164, 73)]
  internal interface IBindingFailedEventArgs
  {
    string Message { get; }
  }
}
