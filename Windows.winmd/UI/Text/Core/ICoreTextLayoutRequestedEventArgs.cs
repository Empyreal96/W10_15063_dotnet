// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextLayoutRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreTextLayoutRequestedEventArgs))]
  [Guid(2984012512, 39547, 20126, 165, 102, 74, 107, 95, 138, 214, 118)]
  internal interface ICoreTextLayoutRequestedEventArgs
  {
    CoreTextLayoutRequest Request { get; }
  }
}
