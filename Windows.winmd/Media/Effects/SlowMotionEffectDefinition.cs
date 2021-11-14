// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.SlowMotionEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.Effects
{
  [Activatable(65536, "Windows.Phone.PhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class SlowMotionEffectDefinition : 
    ISlowMotionEffectDefinition,
    IVideoEffectDefinition
  {
    [MethodImpl]
    public extern SlowMotionEffectDefinition();

    public extern double TimeStretchRate { [MethodImpl] get; [MethodImpl] set; }

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
