// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1179405356, 7338, 16481, 155, 64, 225, 63, 222, 21, 3, 202)]
  internal interface ICompositionAnimation
  {
    void ClearAllParameters();

    void ClearParameter(string key);

    void SetColorParameter(string key, Color value);

    void SetMatrix3x2Parameter(string key, Matrix3x2 value);

    void SetMatrix4x4Parameter(string key, Matrix4x4 value);

    void SetQuaternionParameter(string key, Quaternion value);

    void SetReferenceParameter(string key, CompositionObject compositionObject);

    void SetScalarParameter(string key, float value);

    void SetVector2Parameter(string key, Vector2 value);

    void SetVector3Parameter(string key, Vector3 value);

    void SetVector4Parameter(string key, Vector4 value);
  }
}
