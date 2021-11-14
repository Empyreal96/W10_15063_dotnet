// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2568007367, 35509, 16664, 155, 198, 9, 244, 90, 53, 7, 61)]
  [ExclusiveTo(typeof (DataTemplate))]
  internal interface IDataTemplate
  {
    DependencyObject LoadContent();
  }
}
