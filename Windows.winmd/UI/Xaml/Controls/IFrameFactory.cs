// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Frame))]
  [Guid(49189844, 17550, 18078, 151, 153, 10, 138, 31, 112, 241, 113)]
  internal interface IFrameFactory
  {
    Frame CreateInstance(object outer, out object inner);
  }
}
