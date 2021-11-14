// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.VertexDeclaration
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Graphics
{
  public class VertexDeclaration : GraphicsResource
  {
    internal VertexElement[] _elements;
    internal int _vertexStride;
    internal DeclarationBinding _binding;

    public VertexDeclaration(params VertexElement[] elements)
    {
      this._elements = elements != null && elements.Length != 0 ? (VertexElement[]) elements.Clone() : throw new ArgumentNullException(nameof (elements), FrameworkResources.NullNotAllowed);
      this._vertexStride = VertexElementValidator.GetVertexStride(this._elements);
      VertexElementValidator.Validate(this._vertexStride, this._elements);
    }

    public VertexDeclaration(int vertexStride, params VertexElement[] elements)
    {
      this._elements = elements != null && elements.Length != 0 ? (VertexElement[]) elements.Clone() : throw new ArgumentNullException(nameof (elements), FrameworkResources.NullNotAllowed);
      this._vertexStride = vertexStride;
      VertexElementValidator.Validate(this._vertexStride, this._elements);
    }

    protected override void Dispose(bool disposing)
    {
      try
      {
        this.Unbind();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    public int VertexStride => this._vertexStride;

    public VertexElement[] GetVertexElements() => (VertexElement[]) this._elements.Clone();

    internal void Bind(GraphicsDevice device)
    {
      if (this._isDisposed)
        throw new ObjectDisposedException(typeof (VertexDeclaration).Name);
      VertexElementValidator.Validate(this._vertexStride, this._elements, device._profileCapabilities);
      this.Unbind();
      this._binding = device.vertexDeclarationManager.CreateBinding(this);
      this._parent = device;
    }

    private void Unbind()
    {
      if (this._binding == null)
        return;
      this._parent.vertexDeclarationManager.ReleaseBinding(this._binding);
      this._binding = (DeclarationBinding) null;
    }

    [SecuritySafeCritical]
    internal static VertexDeclaration FromType(Type vertexType)
    {
      if (vertexType == null)
        throw new ArgumentNullException(nameof (vertexType), FrameworkResources.NullNotAllowed);
      if (!vertexType.IsValueType)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexTypeNotValueType, (object) vertexType));
      VertexDeclaration vertexDeclaration = Activator.CreateInstance(vertexType) is IVertexType instance ? instance.VertexDeclaration : throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexTypeNotIVertexType, (object) vertexType));
      if (vertexDeclaration == null)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexTypeNullDeclaration, (object) vertexType));
      if (Marshal.SizeOf(vertexType) != vertexDeclaration._vertexStride)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.VertexTypeWrongSize, (object) vertexType));
      return vertexDeclaration;
    }
  }
}
