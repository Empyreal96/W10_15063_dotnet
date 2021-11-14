// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapTypedValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IBitmapTypedValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BitmapTypedValue : IBitmapTypedValue
  {
    [MethodImpl]
    public extern BitmapTypedValue(object value, PropertyType type);

    public extern object Value { [MethodImpl] get; }

    public extern PropertyType Type { [MethodImpl] get; }
  }
}
