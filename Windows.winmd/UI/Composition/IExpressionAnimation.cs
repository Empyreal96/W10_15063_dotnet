// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IExpressionAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(1791775793, 32061, 19443, 171, 182, 244, 75, 220, 72, 136, 193)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (ExpressionAnimation))]
  internal interface IExpressionAnimation
  {
    string Expression { get; set; }
  }
}
