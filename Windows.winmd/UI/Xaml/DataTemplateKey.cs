// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DataTemplateKey
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IDataTemplateKeyFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class DataTemplateKey : IDataTemplateKey
  {
    [MethodImpl]
    public extern DataTemplateKey();

    [MethodImpl]
    public extern DataTemplateKey(object dataType);

    public extern object DataType { [MethodImpl] get; [MethodImpl] set; }
  }
}
