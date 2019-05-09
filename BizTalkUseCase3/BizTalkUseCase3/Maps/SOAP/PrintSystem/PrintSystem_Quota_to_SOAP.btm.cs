namespace BizTalkUseCase3.Maps.PrintSystem {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL", typeof(global::BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PrintSystem.PrintSystemService_tempuri_org+AddMoney", typeof(global::PrintSystem.PrintSystemService_tempuri_org.AddMoney))]
    public sealed class PrintSystem_Quota_to_SAP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddQuotaFromMSSQL"" />
  </xsl:template>
  <xsl:template match=""/s0:AddQuotaFromMSSQL"">
    <ns0:AddMoney>
      <ns0:id>
        <xsl:value-of select=""UID/text()"" />
      </ns0:id>
      <ns0:chf>
        <xsl:value-of select=""Money/text()"" />
      </ns0:chf>
    </ns0:AddMoney>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL";
        
        private const global::BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PrintSystem.PrintSystemService_tempuri_org+AddMoney";
        
        private const global::PrintSystem.PrintSystemService_tempuri_org.AddMoney _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PrintSystem.PrintSystemService_tempuri_org+AddMoney";
                return _TrgSchemas;
            }
        }
    }
}
