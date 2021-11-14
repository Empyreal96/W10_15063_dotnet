// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreComponentFocusable
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1392078755, 34626, 17425, 174, 105, 121, 168, 95, 41, 172, 139)]
  internal interface ICoreComponentFocusable
  {
    bool HasFocus { get; }

    event TypedEventHandler<object, CoreWindowEventArgs> GotFocus;

    event TypedEventHandler<object, CoreWindowEventArgs> LostFocus;
  }
}
