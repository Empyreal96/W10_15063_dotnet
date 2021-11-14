// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IUnhandledError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (UnhandledError))]
  [WebHostHidden]
  [Guid(2488907558, 21429, 18054, 158, 175, 250, 129, 98, 220, 57, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUnhandledError
  {
    bool Handled { get; }

    void Propagate();
  }
}
