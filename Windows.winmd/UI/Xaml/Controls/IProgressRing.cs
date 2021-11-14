// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IProgressRing
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ProgressRing))]
  [Guid(1839588510, 28317, 16988, 189, 124, 2, 23, 62, 57, 118, 63)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProgressRing
  {
    bool IsActive { get; set; }

    ProgressRingTemplateSettings TemplateSettings { get; }
  }
}
