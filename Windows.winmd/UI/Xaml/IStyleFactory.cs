// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IStyleFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (Style))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2741511395, 15745, 19685, 170, 81, 139, 65, 15, 96, 47, 205)]
  internal interface IStyleFactory
  {
    Style CreateInstance(TypeName targetType);
  }
}
