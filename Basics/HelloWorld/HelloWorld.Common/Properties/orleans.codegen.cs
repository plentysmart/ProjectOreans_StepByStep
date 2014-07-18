//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace HelloWorld.Common
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class HelloWorldFactory
    {
        

                        public static IHelloWorld GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IHelloWorld), -1702375413, primaryKey));
                        }

                        public static IHelloWorld GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IHelloWorld), -1702375413, primaryKey, grainClassNamePrefix));
                        }

                        public static IHelloWorld GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IHelloWorld), -1702375413, primaryKey));
                        }

                        public static IHelloWorld GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IHelloWorld), -1702375413, primaryKey, grainClassNamePrefix));
                        }

            public static IHelloWorld Cast(IAddressable grainRef)
            {
                
                return HelloWorldReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("HelloWorld.Common.IHelloWorld")]
        internal class HelloWorldReference : Orleans.GrainReference, IHelloWorld, Orleans.IAddressable
        {
            

            public static IHelloWorld Cast(IAddressable grainRef)
            {
                
                return (IHelloWorld) GrainReference.CastInternal(typeof(IHelloWorld), (GrainReference gr) => { return new HelloWorldReference(gr);}, grainRef, -1702375413);
            }

                protected override int InterfaceId { get { return -1702375413; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "HelloWorld.Common.IHelloWorld"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return HelloWorldMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal HelloWorldReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                HelloWorldReference input = ((HelloWorldReference)(original));
                return ((HelloWorldReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                HelloWorldReference input = ((HelloWorldReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return HelloWorldReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task Hello(string name)
            {

                return base.InvokeMethodAsync<object>(532006314, new object[] {name}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("HelloWorld.Common.IHelloWorld", -1702375413)]
    internal class HelloWorldMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return -1702375413;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1702375413:  // IHelloWorld
                        switch (methodId)
                        {
                            case 532006314: 
                                await ((IHelloWorld)grain).Hello((String)arguments[0]);
                              return true;
                            default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1702375413:  // IHelloWorld
                    switch (methodId)
                    {
                        case 532006314:
                            return "Hello";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class HelloWorldProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SystemConsoleFactory
    {
        

                        public static ISystemConsole GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(ISystemConsole), 232582239, primaryKey));
                        }

                        public static ISystemConsole GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(ISystemConsole), 232582239, primaryKey, grainClassNamePrefix));
                        }

                        public static ISystemConsole GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(ISystemConsole), 232582239, primaryKey));
                        }

                        public static ISystemConsole GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(ISystemConsole), 232582239, primaryKey, grainClassNamePrefix));
                        }

            public static ISystemConsole Cast(IAddressable grainRef)
            {
                
                return SystemConsoleReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("HelloWorld.Common.ISystemConsole")]
        internal class SystemConsoleReference : Orleans.GrainReference, ISystemConsole, Orleans.IAddressable
        {
            

            public static ISystemConsole Cast(IAddressable grainRef)
            {
                
                return (ISystemConsole) GrainReference.CastInternal(typeof(ISystemConsole), (GrainReference gr) => { return new SystemConsoleReference(gr);}, grainRef, 232582239);
            }

                protected override int InterfaceId { get { return 232582239; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "HelloWorld.Common.ISystemConsole"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return SystemConsoleMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal SystemConsoleReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                SystemConsoleReference input = ((SystemConsoleReference)(original));
                return ((SystemConsoleReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                SystemConsoleReference input = ((SystemConsoleReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return SystemConsoleReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task Display(string message, Nullable<ConsoleColor> color)
            {

                return base.InvokeMethodAsync<object>(1745368991, new object[] {message, color}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("HelloWorld.Common.ISystemConsole", 232582239)]
    internal class SystemConsoleMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return 232582239;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 232582239:  // ISystemConsole
                        switch (methodId)
                        {
                            case 1745368991: 
                                await ((ISystemConsole)grain).Display((String)arguments[0], (Nullable<ConsoleColor>)arguments[1]);
                              return true;
                            default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 232582239:  // ISystemConsole
                    switch (methodId)
                    {
                        case 1745368991:
                            return "Display";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SystemConsoleProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif