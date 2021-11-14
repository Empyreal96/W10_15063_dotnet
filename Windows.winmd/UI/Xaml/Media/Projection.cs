// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Projection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IProjectionFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Projection : DependencyObject, IProjection
  {
    [MethodImpl]
    protected extern Projection();
  }
}
