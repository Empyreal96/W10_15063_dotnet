// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreInputSourceBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2672330759, 17792, 19432, 190, 104, 146, 169, 49, 23, 19, 187)]
  public interface ICoreInputSourceBase
  {
    CoreDispatcher Dispatcher { get; }

    bool IsInputEnabled { get; set; }

    event TypedEventHandler<object, InputEnabledEventArgs> InputEnabled;
  }
}
