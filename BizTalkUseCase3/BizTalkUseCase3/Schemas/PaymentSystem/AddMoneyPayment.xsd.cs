namespace BizTalkUseCase3.Schemas.PaymentSystem {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment",@"AddMoneyPayment")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddMoneyPayment"})]
    public sealed class AddMoneyPayment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AddMoneyPayment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""cardId"" type=""xs:string"" />
        <xs:element name=""money"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AddMoneyPayment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AddMoneyPayment";
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
