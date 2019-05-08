namespace MSSQLService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddMoneyByUsername", @"AddMoneyByUsernameResponse", @"AddMoneyByCard", @"AddMoneyByCardResponse"})]
    public sealed class MSSQLService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AddMoneyByUsername"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""username"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""chf"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddMoneyByUsernameResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddMoneyByCard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""cardId"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""chf"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AddMoneyByCardResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MSSQLService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "AddMoneyByUsername";
                _RootElements[1] = "AddMoneyByUsernameResponse";
                _RootElements[2] = "AddMoneyByCard";
                _RootElements[3] = "AddMoneyByCardResponse";
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
        
        [Schema(@"http://tempuri.org/",@"AddMoneyByUsername")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddMoneyByUsername"})]
        public sealed class AddMoneyByUsername : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddMoneyByUsername() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddMoneyByUsername";
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
        
        [Schema(@"http://tempuri.org/",@"AddMoneyByUsernameResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddMoneyByUsernameResponse"})]
        public sealed class AddMoneyByUsernameResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddMoneyByUsernameResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddMoneyByUsernameResponse";
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
        
        [Schema(@"http://tempuri.org/",@"AddMoneyByCard")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddMoneyByCard"})]
        public sealed class AddMoneyByCard : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddMoneyByCard() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddMoneyByCard";
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
        
        [Schema(@"http://tempuri.org/",@"AddMoneyByCardResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AddMoneyByCardResponse"})]
        public sealed class AddMoneyByCardResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AddMoneyByCardResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AddMoneyByCardResponse";
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
