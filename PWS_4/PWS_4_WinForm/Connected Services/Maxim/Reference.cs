﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PWS_4_WinForm.Maxim {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="A", Namespace="http://cav/")]
    [System.SerializableAttribute()]
    public partial class A : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sField;
        
        private int kField;
        
        private float fField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string s {
            get {
                return this.sField;
            }
            set {
                if ((object.ReferenceEquals(this.sField, value) != true)) {
                    this.sField = value;
                    this.RaisePropertyChanged("s");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int k {
            get {
                return this.kField;
            }
            set {
                if ((this.kField.Equals(value) != true)) {
                    this.kField = value;
                    this.RaisePropertyChanged("k");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public float f {
            get {
                return this.fField;
            }
            set {
                if ((this.fField.Equals(value) != true)) {
                    this.fField = value;
                    this.RaisePropertyChanged("f");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cav/", ConfigurationName="Maxim.SimplexSoap")]
    public interface SimplexSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем упаковщика (sum_1) сообщения sum_1 не соответствует значению по умолчанию (Add).
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_1", ReplyAction="*")]
        PWS_4_WinForm.Maxim.sum_11 Add(PWS_4_WinForm.Maxim.sum_1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_1", ReplyAction="*")]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_11> AddAsync(PWS_4_WinForm.Maxim.sum_1 request);
        
        // CODEGEN: Контракт генерации сообщений с именем упаковщика (sum_2) сообщения sum_2 не соответствует значению по умолчанию (Concat).
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_2", ReplyAction="*")]
        PWS_4_WinForm.Maxim.sum_21 Concat(PWS_4_WinForm.Maxim.sum_2 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_2", ReplyAction="*")]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_21> ConcatAsync(PWS_4_WinForm.Maxim.sum_2 request);
        
        // CODEGEN: Контракт генерации сообщений с именем упаковщика (sum_3) сообщения sum_3 не соответствует значению по умолчанию (Sum).
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_3", ReplyAction="*")]
        PWS_4_WinForm.Maxim.sum_31 Sum(PWS_4_WinForm.Maxim.sum_3 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_3", ReplyAction="*")]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_31> SumAsync(PWS_4_WinForm.Maxim.sum_3 request);
        
        // CODEGEN: Контракт генерации сообщений с именем упаковщика (sum_4) сообщения sum_4 не соответствует значению по умолчанию (Adds).
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_4", ReplyAction="*")]
        PWS_4_WinForm.Maxim.sum_41 Adds(PWS_4_WinForm.Maxim.sum_4 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://cav/sum_4", ReplyAction="*")]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_41> AddsAsync(PWS_4_WinForm.Maxim.sum_4 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_1", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=1)]
        public int y;
        
        public sum_1() {
        }
        
        public sum_1(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_1Response", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_11 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public int sum_1Result;
        
        public sum_11() {
        }
        
        public sum_11(int sum_1Result) {
            this.sum_1Result = sum_1Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_2", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_2 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public string s;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=1)]
        public double d;
        
        public sum_2() {
        }
        
        public sum_2(string s, double d) {
            this.s = s;
            this.d = d;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_2Response", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_21 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public string sum_2Result;
        
        public sum_21() {
        }
        
        public sum_21(string sum_2Result) {
            this.sum_2Result = sum_2Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_3", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_3 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public PWS_4_WinForm.Maxim.A a1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=1)]
        public PWS_4_WinForm.Maxim.A a2;
        
        public sum_3() {
        }
        
        public sum_3(PWS_4_WinForm.Maxim.A a1, PWS_4_WinForm.Maxim.A a2) {
            this.a1 = a1;
            this.a2 = a2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_3Response", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_31 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public PWS_4_WinForm.Maxim.A sum_3Result;
        
        public sum_31() {
        }
        
        public sum_31(PWS_4_WinForm.Maxim.A sum_3Result) {
            this.sum_3Result = sum_3Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_4", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_4 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=1)]
        public int y;
        
        public sum_4() {
        }
        
        public sum_4(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sum_4Response", WrapperNamespace="http://cav/", IsWrapped=true)]
    public partial class sum_41 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://cav/", Order=0)]
        public int sum_4Result;
        
        public sum_41() {
        }
        
        public sum_41(int sum_4Result) {
            this.sum_4Result = sum_4Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SimplexSoapChannel : PWS_4_WinForm.Maxim.SimplexSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimplexSoapClient : System.ServiceModel.ClientBase<PWS_4_WinForm.Maxim.SimplexSoap>, PWS_4_WinForm.Maxim.SimplexSoap {
        
        public SimplexSoapClient() {
        }
        
        public SimplexSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimplexSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimplexSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimplexSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PWS_4_WinForm.Maxim.sum_11 PWS_4_WinForm.Maxim.SimplexSoap.Add(PWS_4_WinForm.Maxim.sum_1 request) {
            return base.Channel.Add(request);
        }
        
        public int Add(int x, int y) {
            PWS_4_WinForm.Maxim.sum_1 inValue = new PWS_4_WinForm.Maxim.sum_1();
            inValue.x = x;
            inValue.y = y;
            PWS_4_WinForm.Maxim.sum_11 retVal = ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).Add(inValue);
            return retVal.sum_1Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_11> PWS_4_WinForm.Maxim.SimplexSoap.AddAsync(PWS_4_WinForm.Maxim.sum_1 request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_11> AddAsync(int x, int y) {
            PWS_4_WinForm.Maxim.sum_1 inValue = new PWS_4_WinForm.Maxim.sum_1();
            inValue.x = x;
            inValue.y = y;
            return ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PWS_4_WinForm.Maxim.sum_21 PWS_4_WinForm.Maxim.SimplexSoap.Concat(PWS_4_WinForm.Maxim.sum_2 request) {
            return base.Channel.Concat(request);
        }
        
        public string Concat(string s, double d) {
            PWS_4_WinForm.Maxim.sum_2 inValue = new PWS_4_WinForm.Maxim.sum_2();
            inValue.s = s;
            inValue.d = d;
            PWS_4_WinForm.Maxim.sum_21 retVal = ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).Concat(inValue);
            return retVal.sum_2Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_21> PWS_4_WinForm.Maxim.SimplexSoap.ConcatAsync(PWS_4_WinForm.Maxim.sum_2 request) {
            return base.Channel.ConcatAsync(request);
        }
        
        public System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_21> ConcatAsync(string s, double d) {
            PWS_4_WinForm.Maxim.sum_2 inValue = new PWS_4_WinForm.Maxim.sum_2();
            inValue.s = s;
            inValue.d = d;
            return ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).ConcatAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PWS_4_WinForm.Maxim.sum_31 PWS_4_WinForm.Maxim.SimplexSoap.Sum(PWS_4_WinForm.Maxim.sum_3 request) {
            return base.Channel.Sum(request);
        }
        
        public PWS_4_WinForm.Maxim.A Sum(PWS_4_WinForm.Maxim.A a1, PWS_4_WinForm.Maxim.A a2) {
            PWS_4_WinForm.Maxim.sum_3 inValue = new PWS_4_WinForm.Maxim.sum_3();
            inValue.a1 = a1;
            inValue.a2 = a2;
            PWS_4_WinForm.Maxim.sum_31 retVal = ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).Sum(inValue);
            return retVal.sum_3Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_31> PWS_4_WinForm.Maxim.SimplexSoap.SumAsync(PWS_4_WinForm.Maxim.sum_3 request) {
            return base.Channel.SumAsync(request);
        }
        
        public System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_31> SumAsync(PWS_4_WinForm.Maxim.A a1, PWS_4_WinForm.Maxim.A a2) {
            PWS_4_WinForm.Maxim.sum_3 inValue = new PWS_4_WinForm.Maxim.sum_3();
            inValue.a1 = a1;
            inValue.a2 = a2;
            return ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).SumAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PWS_4_WinForm.Maxim.sum_41 PWS_4_WinForm.Maxim.SimplexSoap.Adds(PWS_4_WinForm.Maxim.sum_4 request) {
            return base.Channel.Adds(request);
        }
        
        public int Adds(int x, int y) {
            PWS_4_WinForm.Maxim.sum_4 inValue = new PWS_4_WinForm.Maxim.sum_4();
            inValue.x = x;
            inValue.y = y;
            PWS_4_WinForm.Maxim.sum_41 retVal = ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).Adds(inValue);
            return retVal.sum_4Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_41> PWS_4_WinForm.Maxim.SimplexSoap.AddsAsync(PWS_4_WinForm.Maxim.sum_4 request) {
            return base.Channel.AddsAsync(request);
        }
        
        public System.Threading.Tasks.Task<PWS_4_WinForm.Maxim.sum_41> AddsAsync(int x, int y) {
            PWS_4_WinForm.Maxim.sum_4 inValue = new PWS_4_WinForm.Maxim.sum_4();
            inValue.x = x;
            inValue.y = y;
            return ((PWS_4_WinForm.Maxim.SimplexSoap)(this)).AddsAsync(inValue);
        }
    }
}
