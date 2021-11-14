// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IBackRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (BackRequestedEventArgs))]
  [Guid(3590574730, 58385, 19022, 186, 65, 106, 50, 122, 134, 117, 188)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackRequestedEventArgs
  {
    bool Handled { get; set; }
  }
}
