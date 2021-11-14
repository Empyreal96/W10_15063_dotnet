// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionPropertySet
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
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionPropertySet : 
    CompositionObject,
    ICompositionPropertySet,
    ICompositionPropertySet2
  {
    [MethodImpl]
    public extern void InsertColor(string propertyName, Color value);

    [MethodImpl]
    public extern void InsertMatrix3x2(string propertyName, Matrix3x2 value);

    [MethodImpl]
    public extern void InsertMatrix4x4(string propertyName, Matrix4x4 value);

    [MethodImpl]
    public extern void InsertQuaternion(string propertyName, Quaternion value);

    [MethodImpl]
    public extern void InsertScalar(string propertyName, float value);

    [MethodImpl]
    public extern void InsertVector2(string propertyName, Vector2 value);

    [MethodImpl]
    public extern void InsertVector3(string propertyName, Vector3 value);

    [MethodImpl]
    public extern void InsertVector4(string propertyName, Vector4 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetColor(
      string propertyName,
      out Color value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetMatrix3x2(
      string propertyName,
      out Matrix3x2 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetMatrix4x4(
      string propertyName,
      out Matrix4x4 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetQuaternion(
      string propertyName,
      out Quaternion value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetScalar(
      string propertyName,
      out float value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetVector2(
      string propertyName,
      out Vector2 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetVector3(
      string propertyName,
      out Vector3 value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetVector4(
      string propertyName,
      out Vector4 value);

    [MethodImpl]
    public extern void InsertBoolean(string propertyName, bool value);

    [MethodImpl]
    public extern CompositionGetValueStatus TryGetBoolean(
      string propertyName,
      out bool value);
  }
}
