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

  public partial class Position : TBase
  {
    private global::Yaskawa.Ext.API.CoordinateFrame _frame;
    private global::Yaskawa.Ext.API.DistanceUnit _distUnit;
    private global::Yaskawa.Ext.API.OrientationUnit _orientUnit;
    private List<double> _pos;
    private global::Yaskawa.Ext.API.Orient _orient;
    private List<double> _joints;
    private List<long> _closure;
    private List<double> _redundancy;

    public global::Yaskawa.Ext.API.CoordinateFrame Frame
    {
      get
      {
        return _frame;
      }
      set
      {
        __isset.frame = true;
        this._frame = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Yaskawa.Ext.API.DistanceUnit"/>
    /// </summary>
    public global::Yaskawa.Ext.API.DistanceUnit DistUnit
    {
      get
      {
        return _distUnit;
      }
      set
      {
        __isset.distUnit = true;
        this._distUnit = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Yaskawa.Ext.API.OrientationUnit"/>
    /// </summary>
    public global::Yaskawa.Ext.API.OrientationUnit OrientUnit
    {
      get
      {
        return _orientUnit;
      }
      set
      {
        __isset.orientUnit = true;
        this._orientUnit = value;
      }
    }

    public List<double> Pos
    {
      get
      {
        return _pos;
      }
      set
      {
        __isset.pos = true;
        this._pos = value;
      }
    }

    public global::Yaskawa.Ext.API.Orient Orient
    {
      get
      {
        return _orient;
      }
      set
      {
        __isset.orient = true;
        this._orient = value;
      }
    }

    public List<double> Joints
    {
      get
      {
        return _joints;
      }
      set
      {
        __isset.joints = true;
        this._joints = value;
      }
    }

    public List<long> Closure
    {
      get
      {
        return _closure;
      }
      set
      {
        __isset.closure = true;
        this._closure = value;
      }
    }

    public List<double> Redundancy
    {
      get
      {
        return _redundancy;
      }
      set
      {
        __isset.redundancy = true;
        this._redundancy = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool frame;
      public bool distUnit;
      public bool orientUnit;
      public bool pos;
      public bool orient;
      public bool joints;
      public bool closure;
      public bool redundancy;
    }

    public Position()
    {
    }

    public Position DeepCopy()
    {
      var tmp67 = new Position();
      if((Frame != null) && __isset.frame)
      {
        tmp67.Frame = (global::Yaskawa.Ext.API.CoordinateFrame)this.Frame.DeepCopy();
      }
      tmp67.__isset.frame = this.__isset.frame;
      if(__isset.distUnit)
      {
        tmp67.DistUnit = this.DistUnit;
      }
      tmp67.__isset.distUnit = this.__isset.distUnit;
      if(__isset.orientUnit)
      {
        tmp67.OrientUnit = this.OrientUnit;
      }
      tmp67.__isset.orientUnit = this.__isset.orientUnit;
      if((Pos != null) && __isset.pos)
      {
        tmp67.Pos = this.Pos.DeepCopy();
      }
      tmp67.__isset.pos = this.__isset.pos;
      if((Orient != null) && __isset.orient)
      {
        tmp67.Orient = (global::Yaskawa.Ext.API.Orient)this.Orient.DeepCopy();
      }
      tmp67.__isset.orient = this.__isset.orient;
      if((Joints != null) && __isset.joints)
      {
        tmp67.Joints = this.Joints.DeepCopy();
      }
      tmp67.__isset.joints = this.__isset.joints;
      if((Closure != null) && __isset.closure)
      {
        tmp67.Closure = this.Closure.DeepCopy();
      }
      tmp67.__isset.closure = this.__isset.closure;
      if((Redundancy != null) && __isset.redundancy)
      {
        tmp67.Redundancy = this.Redundancy.DeepCopy();
      }
      tmp67.__isset.redundancy = this.__isset.redundancy;
      return tmp67;
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
              if (field.Type == TType.Struct)
              {
                Frame = new global::Yaskawa.Ext.API.CoordinateFrame();
                await Frame.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                DistUnit = (global::Yaskawa.Ext.API.DistanceUnit)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                OrientUnit = (global::Yaskawa.Ext.API.OrientationUnit)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.List)
              {
                {
                  var _list68 = await iprot.ReadListBeginAsync(cancellationToken);
                  Pos = new List<double>(_list68.Count);
                  for(int _i69 = 0; _i69 < _list68.Count; ++_i69)
                  {
                    double _elem70;
                    _elem70 = await iprot.ReadDoubleAsync(cancellationToken);
                    Pos.Add(_elem70);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                Orient = new global::Yaskawa.Ext.API.Orient();
                await Orient.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.List)
              {
                {
                  var _list71 = await iprot.ReadListBeginAsync(cancellationToken);
                  Joints = new List<double>(_list71.Count);
                  for(int _i72 = 0; _i72 < _list71.Count; ++_i72)
                  {
                    double _elem73;
                    _elem73 = await iprot.ReadDoubleAsync(cancellationToken);
                    Joints.Add(_elem73);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.List)
              {
                {
                  var _list74 = await iprot.ReadListBeginAsync(cancellationToken);
                  Closure = new List<long>(_list74.Count);
                  for(int _i75 = 0; _i75 < _list74.Count; ++_i75)
                  {
                    long _elem76;
                    _elem76 = await iprot.ReadI64Async(cancellationToken);
                    Closure.Add(_elem76);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.List)
              {
                {
                  var _list77 = await iprot.ReadListBeginAsync(cancellationToken);
                  Redundancy = new List<double>(_list77.Count);
                  for(int _i78 = 0; _i78 < _list77.Count; ++_i78)
                  {
                    double _elem79;
                    _elem79 = await iprot.ReadDoubleAsync(cancellationToken);
                    Redundancy.Add(_elem79);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var tmp80 = new TStruct("Position");
        await oprot.WriteStructBeginAsync(tmp80, cancellationToken);
        var tmp81 = new TField();
        if((Frame != null) && __isset.frame)
        {
          tmp81.Name = "frame";
          tmp81.Type = TType.Struct;
          tmp81.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await Frame.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.distUnit)
        {
          tmp81.Name = "distUnit";
          tmp81.Type = TType.I32;
          tmp81.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await oprot.WriteI32Async((int)DistUnit, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.orientUnit)
        {
          tmp81.Name = "orientUnit";
          tmp81.Type = TType.I32;
          tmp81.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await oprot.WriteI32Async((int)OrientUnit, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Pos != null) && __isset.pos)
        {
          tmp81.Name = "pos";
          tmp81.Type = TType.List;
          tmp81.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.Double, Pos.Count), cancellationToken);
          foreach (double _iter82 in Pos)
          {
            await oprot.WriteDoubleAsync(_iter82, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Orient != null) && __isset.orient)
        {
          tmp81.Name = "orient";
          tmp81.Type = TType.Struct;
          tmp81.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await Orient.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Joints != null) && __isset.joints)
        {
          tmp81.Name = "joints";
          tmp81.Type = TType.List;
          tmp81.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.Double, Joints.Count), cancellationToken);
          foreach (double _iter83 in Joints)
          {
            await oprot.WriteDoubleAsync(_iter83, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Closure != null) && __isset.closure)
        {
          tmp81.Name = "closure";
          tmp81.Type = TType.List;
          tmp81.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.I64, Closure.Count), cancellationToken);
          foreach (long _iter84 in Closure)
          {
            await oprot.WriteI64Async(_iter84, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Redundancy != null) && __isset.redundancy)
        {
          tmp81.Name = "redundancy";
          tmp81.Type = TType.List;
          tmp81.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp81, cancellationToken);
          await oprot.WriteListBeginAsync(new TList(TType.Double, Redundancy.Count), cancellationToken);
          foreach (double _iter85 in Redundancy)
          {
            await oprot.WriteDoubleAsync(_iter85, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
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
      if (!(that is Position other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.frame == other.__isset.frame) && ((!__isset.frame) || (global::System.Object.Equals(Frame, other.Frame))))
        && ((__isset.distUnit == other.__isset.distUnit) && ((!__isset.distUnit) || (global::System.Object.Equals(DistUnit, other.DistUnit))))
        && ((__isset.orientUnit == other.__isset.orientUnit) && ((!__isset.orientUnit) || (global::System.Object.Equals(OrientUnit, other.OrientUnit))))
        && ((__isset.pos == other.__isset.pos) && ((!__isset.pos) || (global::System.Object.Equals(Pos, other.Pos))))
        && ((__isset.orient == other.__isset.orient) && ((!__isset.orient) || (global::System.Object.Equals(Orient, other.Orient))))
        && ((__isset.joints == other.__isset.joints) && ((!__isset.joints) || (global::System.Object.Equals(Joints, other.Joints))))
        && ((__isset.closure == other.__isset.closure) && ((!__isset.closure) || (global::System.Object.Equals(Closure, other.Closure))))
        && ((__isset.redundancy == other.__isset.redundancy) && ((!__isset.redundancy) || (global::System.Object.Equals(Redundancy, other.Redundancy))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Frame != null) && __isset.frame)
        {
          hashcode = (hashcode * 397) + Frame.GetHashCode();
        }
        if(__isset.distUnit)
        {
          hashcode = (hashcode * 397) + DistUnit.GetHashCode();
        }
        if(__isset.orientUnit)
        {
          hashcode = (hashcode * 397) + OrientUnit.GetHashCode();
        }
        if((Pos != null) && __isset.pos)
        {
          hashcode = (hashcode * 397) + Pos.GetHashCode();
        }
        if((Orient != null) && __isset.orient)
        {
          hashcode = (hashcode * 397) + Orient.GetHashCode();
        }
        if((Joints != null) && __isset.joints)
        {
          hashcode = (hashcode * 397) + Joints.GetHashCode();
        }
        if((Closure != null) && __isset.closure)
        {
          hashcode = (hashcode * 397) + Closure.GetHashCode();
        }
        if((Redundancy != null) && __isset.redundancy)
        {
          hashcode = (hashcode * 397) + Redundancy.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp86 = new StringBuilder("Position(");
      int tmp87 = 0;
      if((Frame != null) && __isset.frame)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Frame: ");
        Frame.ToString(tmp86);
      }
      if(__isset.distUnit)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("DistUnit: ");
        DistUnit.ToString(tmp86);
      }
      if(__isset.orientUnit)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("OrientUnit: ");
        OrientUnit.ToString(tmp86);
      }
      if((Pos != null) && __isset.pos)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Pos: ");
        Pos.ToString(tmp86);
      }
      if((Orient != null) && __isset.orient)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Orient: ");
        Orient.ToString(tmp86);
      }
      if((Joints != null) && __isset.joints)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Joints: ");
        Joints.ToString(tmp86);
      }
      if((Closure != null) && __isset.closure)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Closure: ");
        Closure.ToString(tmp86);
      }
      if((Redundancy != null) && __isset.redundancy)
      {
        if(0 < tmp87++) { tmp86.Append(", "); }
        tmp86.Append("Redundancy: ");
        Redundancy.ToString(tmp86);
      }
      tmp86.Append(')');
      return tmp86.ToString();
    }
  }

}
