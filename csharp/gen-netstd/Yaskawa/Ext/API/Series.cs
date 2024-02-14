/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{

  /// <summary>
  /// Data structures for passing values to charts for plotting
  /// 
  /// Series data is used for line and scatter charts, while
  /// category data is used for pie and bar charts
  /// </summary>
  public partial class Series : TBase
  {
    private List<double> _x;
    private List<double> _y;
    private List<double> _z;
    private string _color;
    private string _vertex;
    private string _style;
    private bool _hidden;
    private int _maxPts;

    public List<double> X
    {
      get
      {
        return _x;
      }
      set
      {
        __isset.x = true;
        this._x = value;
      }
    }

    public List<double> Y
    {
      get
      {
        return _y;
      }
      set
      {
        __isset.y = true;
        this._y = value;
      }
    }

    public List<double> Z
    {
      get
      {
        return _z;
      }
      set
      {
        __isset.z = true;
        this._z = value;
      }
    }

    public string Color
    {
      get
      {
        return _color;
      }
      set
      {
        __isset.color = true;
        this._color = value;
      }
    }

    public string Vertex
    {
      get
      {
        return _vertex;
      }
      set
      {
        __isset.vertex = true;
        this._vertex = value;
      }
    }

    public string Style
    {
      get
      {
        return _style;
      }
      set
      {
        __isset.style = true;
        this._style = value;
      }
    }

    public bool Hidden
    {
      get
      {
        return _hidden;
      }
      set
      {
        __isset.hidden = true;
        this._hidden = value;
      }
    }

    public int MaxPts
    {
      get
      {
        return _maxPts;
      }
      set
      {
        __isset.maxPts = true;
        this._maxPts = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool x;
      public bool y;
      public bool z;
      public bool color;
      public bool vertex;
      public bool style;
      public bool hidden;
      public bool maxPts;
    }

    public Series()
    {
    }

    public Series DeepCopy()
    {
      var tmp111 = new Series();
      if((X != null) && __isset.x)
      {
        tmp111.X = this.X.DeepCopy();
      }
      tmp111.__isset.x = this.__isset.x;
      if((Y != null) && __isset.y)
      {
        tmp111.Y = this.Y.DeepCopy();
      }
      tmp111.__isset.y = this.__isset.y;
      if((Z != null) && __isset.z)
      {
        tmp111.Z = this.Z.DeepCopy();
      }
      tmp111.__isset.z = this.__isset.z;
      if((Color != null) && __isset.color)
      {
        tmp111.Color = this.Color;
      }
      tmp111.__isset.color = this.__isset.color;
      if((Vertex != null) && __isset.vertex)
      {
        tmp111.Vertex = this.Vertex;
      }
      tmp111.__isset.vertex = this.__isset.vertex;
      if((Style != null) && __isset.style)
      {
        tmp111.Style = this.Style;
      }
      tmp111.__isset.style = this.__isset.style;
      if(__isset.hidden)
      {
        tmp111.Hidden = this.Hidden;
      }
      tmp111.__isset.hidden = this.__isset.hidden;
      if(__isset.maxPts)
      {
        tmp111.MaxPts = this.MaxPts;
      }
      tmp111.__isset.maxPts = this.__isset.maxPts;
      return tmp111;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.List)
              {
                {
                  var _list112 = await iprot.ReadListBeginAsync(cancellationToken);
                  X = new List<double>(_list112.Count);
                  for(int _i113 = 0; _i113 < _list112.Count; ++_i113)
                  {
                    double _elem114;
                    _elem114 = await iprot.ReadDoubleAsync(cancellationToken);
                    X.Add(_elem114);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  var _list115 = await iprot.ReadListBeginAsync(cancellationToken);
                  Y = new List<double>(_list115.Count);
                  for(int _i116 = 0; _i116 < _list115.Count; ++_i116)
                  {
                    double _elem117;
                    _elem117 = await iprot.ReadDoubleAsync(cancellationToken);
                    Y.Add(_elem117);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  var _list118 = await iprot.ReadListBeginAsync(cancellationToken);
                  Z = new List<double>(_list118.Count);
                  for(int _i119 = 0; _i119 < _list118.Count; ++_i119)
                  {
                    double _elem120;
                    _elem120 = await iprot.ReadDoubleAsync(cancellationToken);
                    Z.Add(_elem120);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Color = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                Vertex = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Style = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Bool)
              {
                Hidden = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I32)
              {
                MaxPts = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp121 = new TStruct("Series");
        await oprot.WriteStructBeginAsync(tmp121, cancellationToken);
        var tmp122 = new TField();
        if((X != null) && __isset.x)
        {
          tmp122.Name = "x";
          tmp122.Type = TType.List;
          tmp122.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.Double, X.Count), cancellationToken);
          foreach (double _iter123 in X)
          {
            await oprot.WriteDoubleAsync(_iter123, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Y != null) && __isset.y)
        {
          tmp122.Name = "y";
          tmp122.Type = TType.List;
          tmp122.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.Double, Y.Count), cancellationToken);
          foreach (double _iter124 in Y)
          {
            await oprot.WriteDoubleAsync(_iter124, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Z != null) && __isset.z)
        {
          tmp122.Name = "z";
          tmp122.Type = TType.List;
          tmp122.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.Double, Z.Count), cancellationToken);
          foreach (double _iter125 in Z)
          {
            await oprot.WriteDoubleAsync(_iter125, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Color != null) && __isset.color)
        {
          tmp122.Name = "color";
          tmp122.Type = TType.String;
          tmp122.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteStringAsync(Color, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Vertex != null) && __isset.vertex)
        {
          tmp122.Name = "vertex";
          tmp122.Type = TType.String;
          tmp122.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteStringAsync(Vertex, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Style != null) && __isset.style)
        {
          tmp122.Name = "style";
          tmp122.Type = TType.String;
          tmp122.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteStringAsync(Style, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.hidden)
        {
          tmp122.Name = "hidden";
          tmp122.Type = TType.Bool;
          tmp122.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteBoolAsync(Hidden, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.maxPts)
        {
          tmp122.Name = "maxPts";
          tmp122.Type = TType.I32;
          tmp122.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp122, cancellationToken);
          await oprot.WriteI32Async(MaxPts, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is Series other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.x == other.__isset.x) && ((!__isset.x) || (global::System.Object.Equals(X, other.X))))
        && ((__isset.y == other.__isset.y) && ((!__isset.y) || (global::System.Object.Equals(Y, other.Y))))
        && ((__isset.z == other.__isset.z) && ((!__isset.z) || (global::System.Object.Equals(Z, other.Z))))
        && ((__isset.color == other.__isset.color) && ((!__isset.color) || (global::System.Object.Equals(Color, other.Color))))
        && ((__isset.vertex == other.__isset.vertex) && ((!__isset.vertex) || (global::System.Object.Equals(Vertex, other.Vertex))))
        && ((__isset.style == other.__isset.style) && ((!__isset.style) || (global::System.Object.Equals(Style, other.Style))))
        && ((__isset.hidden == other.__isset.hidden) && ((!__isset.hidden) || (global::System.Object.Equals(Hidden, other.Hidden))))
        && ((__isset.maxPts == other.__isset.maxPts) && ((!__isset.maxPts) || (global::System.Object.Equals(MaxPts, other.MaxPts))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((X != null) && __isset.x)
        {
          hashcode = (hashcode * 397) + X.GetHashCode();
        }
        if((Y != null) && __isset.y)
        {
          hashcode = (hashcode * 397) + Y.GetHashCode();
        }
        if((Z != null) && __isset.z)
        {
          hashcode = (hashcode * 397) + Z.GetHashCode();
        }
        if((Color != null) && __isset.color)
        {
          hashcode = (hashcode * 397) + Color.GetHashCode();
        }
        if((Vertex != null) && __isset.vertex)
        {
          hashcode = (hashcode * 397) + Vertex.GetHashCode();
        }
        if((Style != null) && __isset.style)
        {
          hashcode = (hashcode * 397) + Style.GetHashCode();
        }
        if(__isset.hidden)
        {
          hashcode = (hashcode * 397) + Hidden.GetHashCode();
        }
        if(__isset.maxPts)
        {
          hashcode = (hashcode * 397) + MaxPts.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp126 = new StringBuilder("Series(");
      int tmp127 = 0;
      if((X != null) && __isset.x)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("X: ");
        X.ToString(tmp126);
      }
      if((Y != null) && __isset.y)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("Y: ");
        Y.ToString(tmp126);
      }
      if((Z != null) && __isset.z)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("Z: ");
        Z.ToString(tmp126);
      }
      if((Color != null) && __isset.color)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("Color: ");
        Color.ToString(tmp126);
      }
      if((Vertex != null) && __isset.vertex)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("Vertex: ");
        Vertex.ToString(tmp126);
      }
      if((Style != null) && __isset.style)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("Style: ");
        Style.ToString(tmp126);
      }
      if(__isset.hidden)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("Hidden: ");
        Hidden.ToString(tmp126);
      }
      if(__isset.maxPts)
      {
        if(0 < tmp127++) { tmp126.Append(", "); }
        tmp126.Append("MaxPts: ");
        MaxPts.ToString(tmp126);
      }
      tmp126.Append(')');
      return tmp126.ToString();
    }
  }

}
