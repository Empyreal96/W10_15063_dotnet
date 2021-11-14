// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextEditContext2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CoreTextEditContext))]
  [Guid(2978381243, 2107, 18913, 178, 129, 43, 53, 214, 43, 244, 102)]
  internal interface ICoreTextEditContext2
  {
    event TypedEventHandler<CoreTextEditContext, object> NotifyFocusLeaveCompleted;
  }
}
