namespace BizTalkUseCase3.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUseCase3.Schemas.MSSQLSystem.BuyCopiesFromPayment", typeof(global::BizTalkUseCase3.Schemas.MSSQLSystem.BuyCopiesFromPayment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSSQLService.MSSQLService_tempuri_org+AddMoneyByCard", typeof(global::MSSQLService.MSSQLService_tempuri_org.AddMoneyByCard))]
    public sealed class MSSQL_Payment_to_SOAP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalkUseCase3.Schemas.MSSQLSystem.BuyCopiesFromPayment"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:BuyCopiesFromPayment"" />
  </xsl:template>
  <xsl:template match=""/s0:BuyCopiesFromPayment"">
    <ns0:AddMoneyByCard>
      <ns0:cardId>
        <xsl:value-of select=""CardId/text()"" />
      </ns0:cardId>
      <ns0:chf>
        <xsl:value-of select=""Money/text()"" />
      </ns0:chf>
    </ns0:AddMoneyByCard>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkUseCase3.Schemas.MSSQLSystem.BuyCopiesFromPayment";
        
        private const global::BizTalkUseCase3.Schemas.MSSQLSystem.BuyCopiesFromPayment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MSSQLService.MSSQLService_tempuri_org+AddMoneyByCard";
        
        private const global::MSSQLService.MSSQLService_tempuri_org.AddMoneyByCard _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkUseCase3.Schemas.MSSQLSystem.BuyCopiesFromPayment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MSSQLService.MSSQLService_tempuri_org+AddMoneyByCard";
                return _TrgSchemas;
            }
        }
    }
}
