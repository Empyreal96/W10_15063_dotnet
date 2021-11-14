// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ITransformPattern2IdentifiersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (TransformPattern2Identifiers))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2023110212, 4592, 18044, 167, 43, 93, 172, 65, 193, 246, 254)]
  [WebHostHidden]
  internal interface ITransformPattern2IdentifiersStatics
  {
    AutomationProperty CanZoomProperty { get; }

    AutomationProperty ZoomLevelProperty { get; }

    AutomationProperty MaxZoomProperty { get; }

    AutomationProperty MinZoomProperty { get; }
  }
}
