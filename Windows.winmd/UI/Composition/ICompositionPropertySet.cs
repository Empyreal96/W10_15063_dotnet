// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionPropertySet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(3386298882, 24423, 17491, 145, 23, 158, 173, 212, 48, 211, 194)]
  [ExclusiveTo(typeof (CompositionPropertySet))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionPropertySet
  {
    void InsertColor(string propertyName, Color value);

    void InsertMatrix3x2(string propertyName, Matrix3x2 value);

    void InsertMatrix4x4(string propertyName, Matrix4x4 value);

    void InsertQuaternion(string propertyName, Quaternion value);

    void InsertScalar(string propertyName, float value);

    void InsertVector2(string propertyName, Vector2 value);

    void InsertVector3(string propertyName, Vector3 value);

    void InsertVector4(string propertyName, Vector4 value);

    CompositionGetValueStatus TryGetColor(
      string propertyName,
      out Color value);

    CompositionGetValueStatus TryGetMatrix3x2(
      string propertyName,
      out Matrix3x2 value);

    CompositionGetValueStatus TryGetMatrix4x4(
      string propertyName,
      out Matrix4x4 value);

    CompositionGetValueStatus TryGetQuaternion(
      string propertyName,
      out Quaternion value);

    CompositionGetValueStatus TryGetScalar(
      string propertyName,
      out float value);

    CompositionGetValueStatus TryGetVector2(
      string propertyName,
      out Vector2 value);

    CompositionGetValueStatus TryGetVector3(
      string propertyName,
      out Vector3 value);

    CompositionGetValueStatus TryGetVector4(
      string propertyName,
      out Vector4 value);
  }
}
