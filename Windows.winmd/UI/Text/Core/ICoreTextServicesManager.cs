// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextServicesManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextServicesManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3260054915, 28170, 19082, 189, 248, 25, 72, 135, 72, 84, 186)]
  internal interface ICoreTextServicesManager
  {
    Language InputLanguage { get; }

    event TypedEventHandler<CoreTextServicesManager, object> InputLanguageChanged;

    CoreTextEditContext CreateEditContext();
  }
}
