namespace PaymentService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddMoney", @"AddMoneyResponse", @"BuyPhotocopies", @"BuyPhotocopiesResponse"})]
    public sealed class PaymentService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AddMoney"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""card"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""chf"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddMoneyResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""BuyPhotocopies"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""card"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""chf"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BuyPhotocopiesResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PaymentService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "AddMoney";
                _RootElements[1] = "AddMoneyResponse";
                _RootElements[2] = "BuyPhotocopies";
                _RootElements[3] = "BuyPhotocopiesResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddMoney")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddMoney"})]
        public sealed class AddMoney : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddMoney() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddMoney";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"AddMoneyResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddMoneyResponse"})]
        public sealed class AddMoneyResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddMoneyResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddMoneyResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"BuyPhotocopies")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BuyPhotocopies"})]
        public sealed class BuyPhotocopies : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BuyPhotocopies() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BuyPhotocopies";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"BuyPhotocopiesResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BuyPhotocopiesResponse"})]
        public sealed class BuyPhotocopiesResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BuyPhotocopiesResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BuyPhotocopiesResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
