// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapTypedValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(3447735465, 9283, 16384, 176, 205, 121, 49, 108, 86, 245, 137)]
  [ExclusiveTo(typeof (BitmapTypedValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapTypedValue
  {
    object Value { get; }

    PropertyType Type { get; }
  }
}
