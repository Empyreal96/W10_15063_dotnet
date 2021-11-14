// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICompositionAnimationFactory), CompositionType.Protected, 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public class CompositionAnimation : 
    CompositionObject,
    ICompositionAnimation,
    ICompositionAnimation2,
    ICompositionAnimationBase
  {
    [MethodImpl]
    public extern void ClearAllParameters();

    [MethodImpl]
    public extern void ClearParameter(string key);

    [MethodImpl]
    public extern void SetColorParameter(string key, Color value);

    [MethodImpl]
    public extern void SetMatrix3x2Parameter(string key, Matrix3x2 value);

    [MethodImpl]
    public extern void SetMatrix4x4Parameter(string key, Matrix4x4 value);

    [MethodImpl]
    public extern void SetQuaternionParameter(string key, Quaternion value);

    [MethodImpl]
    public extern void SetReferenceParameter(string key, CompositionObject compositionObject);

    [MethodImpl]
    public extern void SetScalarParameter(string key, float value);

    [MethodImpl]
    public extern void SetVector2Parameter(string key, Vector2 value);

    [MethodImpl]
    public extern void SetVector3Parameter(string key, Vector3 value);

    [MethodImpl]
    public extern void SetVector4Parameter(string key, Vector4 value);

    [MethodImpl]
    public extern void SetBooleanParameter(string key, bool value);

    public extern string Target { [MethodImpl] get; [MethodImpl] set; }
  }
}
