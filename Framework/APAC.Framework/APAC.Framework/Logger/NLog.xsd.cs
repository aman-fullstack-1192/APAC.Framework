namespace APAC.Framework {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.nlog-project.org/schemas/NLog.xsd",@"nlog")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"nlog"})]
    public sealed class NLog : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.nlog-project.org/schemas/NLog.xsd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.nlog-project.org/schemas/NLog.xsd"" id=""NLog"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""nlog"" type=""NLogConfiguration"" />
  <xs:complexType name=""NLogConfiguration"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""extensions"" type=""NLogExtensions"" />
      <xs:element name=""include"" type=""NLogInclude"" />
      <xs:element name=""variable"" type=""NLogVariable"" />
      <xs:element name=""targets"" type=""NLogTargets"" />
      <xs:element name=""rules"" type=""NLogRules"" />
      <xs:element name=""time"" type=""TimeSource"" />
    </xs:choice>
    <xs:attribute name=""autoReload"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Watch config file for changes and reload automatically.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""internalLogToConsole"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Print internal NLog messages to the console. Default value is: false</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""internalLogToConsoleError"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Print internal NLog messages to the console error output. Default value is: false</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""internalLogFile"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Write internal NLog messages to the specified file.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""internalLogLevel"" type=""NLogLevel"">
      <xs:annotation>
        <xs:documentation>Log level threshold for internal log messages. Default value is: Info.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""globalThreshold"" type=""NLogLevel"">
      <xs:annotation>
        <xs:documentation>Global log level threshold for application log messages. Messages below this level won't be logged..</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""throwExceptions"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Throw an exception when there is an internal error. Default value is: false.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""throwConfigExceptions"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Throw an exception when there is a configuration error. If not set, determined by throwExceptions.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""keepVariablesOnReload"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Gets or sets a value indicating whether Variables should be kept on configuration reload. Default value is: false.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""internalLogToTrace"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Write internal NLog messages to the System.Diagnostics.Trace. Default value is: false.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""internalLogIncludeTimestamp"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Write timestamps for internal NLog messages. Default value is: true.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""useInvariantCulture"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Use InvariantCulture as default culture instead of CurrentCulture.  Default value is: false.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""parseMessageTemplates"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Perform mesage template parsing and formatting of LogEvent messages (true = Always, false = Never, empty = Auto Detect). Default value is: empty.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLogTargets"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""default-wrapper"" type=""WrapperTargetBase"" />
      <xs:element name=""default-target-parameters"" type=""Target"" />
      <xs:element name=""target"" type=""Target"" />
      <xs:element name=""wrapper-target"" type=""WrapperTargetBase"" />
      <xs:element name=""compound-target"" type=""CompoundTargetBase"" />
    </xs:choice>
    <xs:attribute name=""async"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Make all targets within this section asynchronous (creates additional threads but the calling thread isn't blocked by any target writes).</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLogRules"">
    <xs:sequence minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""logger"" type=""NLogLoggerRule"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NLogExtensions"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""add"" type=""NLogExtensionsAdd"" />
    </xs:choice>
  </xs:complexType>
  <xs:complexType name=""NLogExtensionsAdd"">
    <xs:attribute name=""prefix"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Prefix for targets/layout renderers/filters/conditions loaded from this assembly.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""assemblyFile"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Load NLog extensions from the specified file (*.dll)</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""assembly"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Load NLog extensions from the specified assembly. Assembly name should be fully qualified.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLogLoggerRule"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""filters"" type=""NLogFilters"" />
    </xs:choice>
    <xs:attribute name=""name"" type=""xs:string"" use=""optional"">
      <xs:annotation>
        <xs:documentation>Name of the logger. May include '*' character which acts like a wildcard. Allowed forms are: *, Name, *Name, Name* and *Name*</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""levels"" type=""NLogLevelList"">
      <xs:annotation>
        <xs:documentation>Comma separated list of levels that this rule matches.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""minlevel"" type=""NLogLevel"">
      <xs:annotation>
        <xs:documentation>Minimum level that this rule matches.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""maxlevel"" type=""NLogLevel"">
      <xs:annotation>
        <xs:documentation>Maximum level that this rule matches.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""level"" type=""NLogLevel"">
      <xs:annotation>
        <xs:documentation>Level that this rule matches.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""writeTo"" type=""NLogTargetIDList"">
      <xs:annotation>
        <xs:documentation>Comma separated list of target names.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute default=""false"" name=""final"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Ignore further rules if this one matches.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute default=""true"" name=""enabled"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Enable or disable logging rule. Disabled rules are ignored.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLogFilters"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""when"" type=""when"" />
      <xs:element name=""whenContains"" type=""whenContains"" />
      <xs:element name=""whenEqual"" type=""whenEqual"" />
      <xs:element name=""whenNotContains"" type=""whenNotContains"" />
      <xs:element name=""whenNotEqual"" type=""whenNotEqual"" />
      <xs:element name=""whenRepeated"" type=""whenRepeated"" />
    </xs:choice>
  </xs:complexType>
  <xs:simpleType name=""NLogLevel"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Off"" />
      <xs:enumeration value=""Trace"" />
      <xs:enumeration value=""Debug"" />
      <xs:enumeration value=""Info"" />
      <xs:enumeration value=""Warn"" />
      <xs:enumeration value=""Error"" />
      <xs:enumeration value=""Fatal"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""LineEndingMode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Default"" />
      <xs:enumeration value=""CRLF"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""None"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLogLevelList"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(|Trace|Debug|Info|Warn|Error|Fatal)(,(Trace|Debug|Info|Warn|Error|Fatal))*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NLogInclude"">
    <xs:attribute name=""file"" type=""SimpleLayoutAttribute"" use=""required"">
      <xs:annotation>
        <xs:documentation>Name of the file to be included. You could use * wildcard. The name is relative to the name of the current config file.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute default=""false"" name=""ignoreErrors"" type=""xs:boolean"" use=""optional"">
      <xs:annotation>
        <xs:documentation>Ignore any errors in the include file.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLogVariable"">
    <xs:attribute name=""name"" type=""xs:string"" use=""required"">
      <xs:annotation>
        <xs:documentation>Variable name.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""value"" type=""SimpleLayoutAttribute"" use=""required"">
      <xs:annotation>
        <xs:documentation>Variable value.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:simpleType name=""NLogTargetIDList"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(|([a-zA-Z][a-zA-Z0-9_\-]*))(,([a-zA-Z][a-zA-Z0-9_\-]*))*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""Target"" abstract=""true"" />
  <xs:complexType name=""TargetRef"">
    <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
  </xs:complexType>
  <xs:complexType name=""WrapperTargetBase"" abstract=""true"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""target"" type=""Target"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""wrapper-target"" type=""WrapperTargetBase"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""compound-target"" type=""CompoundTargetBase"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""target-ref"" type=""TargetRef"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""wrapper-target-ref"" type=""TargetRef"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""compound-target-ref"" type=""TargetRef"" />
        </xs:choice>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""CompoundTargetBase"" abstract=""true"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""target"" type=""Target"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""wrapper-target"" type=""WrapperTargetBase"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""compound-target"" type=""CompoundTargetBase"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""target-ref"" type=""TargetRef"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""wrapper-target-ref"" type=""TargetRef"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""compound-target-ref"" type=""TargetRef"" />
        </xs:choice>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Filter"" abstract=""true"" />
  <xs:complexType name=""TimeSource"" abstract=""true"" />
  <xs:simpleType name=""SimpleLayoutAttribute"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value="".*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Condition"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""AsyncWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""batchSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""fullBatchSizeWriteLimit"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""overflowAction"" type=""NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""queueLimit"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""timeToSleepBetweenBatches"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""batchSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Number of log events that should be processed in a batch by the lazy writer thread.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""fullBatchSizeWriteLimit"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Limit of full s to write before yielding into  Performance is better when writing many small batches, than writing a single large batch</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""overflowAction"" type=""NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action to be taken when the lazy writer thread request queue count exceeds the set limit.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""queueLimit"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Limit on the number of requests in the lazy writer thread request queue.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""timeToSleepBetweenBatches"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Time in milliseconds to sleep between batches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Grow"" />
      <xs:enumeration value=""Discard"" />
      <xs:enumeration value=""Block"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""AutoFlushWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""asyncFlush"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""condition"" type=""Condition"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""asyncFlush"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Delay the flush until the LogEvent has been confirmed as written</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""condition"" type=""Condition"">
          <xs:annotation>
            <xs:documentation>Condition expression. Log events who meet this condition will cause a flush on the wrapped target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""BufferingWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""bufferSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""flushTimeout"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""overflowAction"" type=""NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""slidingTimeout"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""bufferSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Number of log events to be buffered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""flushTimeout"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Timeout (in milliseconds) after which the contents of buffer will be flushed if there's no write in the specified period of time. Use -1 to disable timed flushes.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""overflowAction"" type=""NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action to take if the buffer overflows.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""slidingTimeout"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to use sliding timeout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Flush"" />
      <xs:enumeration value=""Discard"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""Chainsaw"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lineEnding"" type=""LineEndingMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxMessageSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""newLine"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onConnectionOverflow"" type=""NLog.Targets.NetworkTargetConnectionsOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxQueueSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxConnections"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""keepConnection"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""connectionCacheSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""address"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onOverflow"" type=""NLog.Targets.NetworkTargetOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.NLogViewerParameterInfo"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ndlcItemSeparator"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ndcItemSeparator"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNLogData"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeSourceInfo"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNdlc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdlc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeCallSite"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeAllProperties"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""appInfo"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""loggerName"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Encoding to be used.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Instance of  that is used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""lineEnding"" type=""LineEndingMode"">
          <xs:annotation>
            <xs:documentation>End of line value if a newline is appended at the end of log message .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxMessageSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum message size in bytes.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""newLine"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to append newline at the end of log message.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onConnectionOverflow"" type=""NLog.Targets.NetworkTargetConnectionsOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action that should be taken if the will be more connections than .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxQueueSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum queue size.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxConnections"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum current connections. 0 = no maximum.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""keepConnection"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to keep connection open whenever possible.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""connectionCacheSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Size of the connection cache (number of connections which are kept alive).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""address"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Network address.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onOverflow"" type=""NLog.Targets.NetworkTargetOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action that should be taken if the message is larger than maxMessageSize.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ndlcItemSeparator"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>NDLC item separator.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ndcItemSeparator"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>NDC item separator.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNLogData"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include NLog-specific extensions to log4j schema.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeSourceInfo"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include source info (file name and line number) in the information sent over the network.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  stack.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include  stack contents.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include  dictionary contents.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include  dictionary contents.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeCallSite"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include call site (class and method name) in the information sent over the network.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeAllProperties"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Option to include all properties from the log events</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""appInfo"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>AppInfo field. By default it's the friendly name of the current AppDomain.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""loggerName"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Renderer for log4j:event logger-xml-attribute (Default ${logger})</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.NetworkTargetConnectionsOverflowAction"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AllowNewConnnection"" />
      <xs:enumeration value=""DiscardMessage"" />
      <xs:enumeration value=""Block"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.NetworkTargetOverflowAction"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Error"" />
      <xs:enumeration value=""Split"" />
      <xs:enumeration value=""Discard"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NLog.Targets.NLogViewerParameterInfo"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
    </xs:choice>
    <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Layout that should be use to calcuate the value for the parameter.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""name"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Viewer parameter name.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""ColoredConsole"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""detectConsoleAvailable"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""errorStream"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""useDefaultRowHighlightingRules"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""highlight-row"" type=""NLog.Targets.ConsoleRowHighlightingRule"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""highlight-word"" type=""NLog.Targets.ConsoleWordHighlightingRule"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Text to be rendered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""detectConsoleAvailable"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to auto-check if the console is available. - Disables console writing if Environment.UserInteractive = False (Windows Service) - Disables console writing if Console Standard Input is not available (Non-Console-App)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>The encoding for writing messages to the .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""errorStream"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether the error stream (stderr) should be used instead of the output stream (stdout).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""useDefaultRowHighlightingRules"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to use default row highlighting rules.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.ConsoleOutputColor"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Black"" />
      <xs:enumeration value=""DarkBlue"" />
      <xs:enumeration value=""DarkGreen"" />
      <xs:enumeration value=""DarkCyan"" />
      <xs:enumeration value=""DarkRed"" />
      <xs:enumeration value=""DarkMagenta"" />
      <xs:enumeration value=""DarkYellow"" />
      <xs:enumeration value=""Gray"" />
      <xs:enumeration value=""DarkGray"" />
      <xs:enumeration value=""Blue"" />
      <xs:enumeration value=""Green"" />
      <xs:enumeration value=""Cyan"" />
      <xs:enumeration value=""Red"" />
      <xs:enumeration value=""Magenta"" />
      <xs:enumeration value=""Yellow"" />
      <xs:enumeration value=""White"" />
      <xs:enumeration value=""NoChange"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NLog.Targets.ConsoleRowHighlightingRule"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""condition"" type=""Condition"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""backgroundColor"" type=""NLog.Targets.ConsoleOutputColor"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""foregroundColor"" type=""NLog.Targets.ConsoleOutputColor"" />
    </xs:choice>
    <xs:attribute name=""condition"" type=""Condition"">
      <xs:annotation>
        <xs:documentation>Condition that must be met in order to set the specified foreground and background color.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""backgroundColor"" type=""NLog.Targets.ConsoleOutputColor"">
      <xs:annotation>
        <xs:documentation>Background color.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""foregroundColor"" type=""NLog.Targets.ConsoleOutputColor"">
      <xs:annotation>
        <xs:documentation>Foreground color.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLog.Targets.ConsoleWordHighlightingRule"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""compileRegex"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ignoreCase"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""regex"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""wholeWords"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""backgroundColor"" type=""NLog.Targets.ConsoleOutputColor"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""foregroundColor"" type=""NLog.Targets.ConsoleOutputColor"" />
    </xs:choice>
    <xs:attribute name=""compileRegex"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Compile the ? This can improve the performance, but at the costs of more memory usage. If false, the Regex Cache is used.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""ignoreCase"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Indicates whether to ignore case when comparing texts.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""regex"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Regular expression to be matched. You must specify either text or regex.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""text"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Text to be matched. You must specify either text or regex.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""wholeWords"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Indicates whether to match whole words only.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""backgroundColor"" type=""NLog.Targets.ConsoleOutputColor"">
      <xs:annotation>
        <xs:documentation>Background color.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""foregroundColor"" type=""NLog.Targets.ConsoleOutputColor"">
      <xs:annotation>
        <xs:documentation>Foreground color.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""Console"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""detectConsoleAvailable"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""error"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Text to be rendered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""detectConsoleAvailable"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to auto-check if the console is available - Disables console writing if Environment.UserInteractive = False (Windows Service) - Disables console writing if Console Standard Input is not available (Non-Console-App)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>The encoding for writing messages to the .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""error"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to send the log messages to the standard error instead of the standard output.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Database"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""useTransactions"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""dbUserName"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""dbProvider"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""dbPassword"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""keepConnection"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""dbDatabase"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""connectionStringName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""connectionString"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""dbHost"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""installConnectionString"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""install-command"" type=""NLog.Targets.DatabaseCommandInfo"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""uninstall-command"" type=""NLog.Targets.DatabaseCommandInfo"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.DatabaseParameterInfo"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""commandText"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""commandType"" type=""System.Data.CommandType"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""useTransactions"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Obsolete - value will be ignored! The logging code always runs outside of transaction. Gets or sets a value indicating whether to use database transactions. Some data providers require this.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""dbUserName"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Database user name. If the ConnectionString is not provided this value will be used to construct the ""User ID="" part of the connection string.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""dbProvider"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the database provider.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""dbPassword"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Database password. If the ConnectionString is not provided this value will be used to construct the ""Password="" part of the connection string.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""keepConnection"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to keep the database connection open between the log events.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""dbDatabase"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Database name. If the ConnectionString is not provided this value will be used to construct the ""Database="" part of the connection string.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""connectionStringName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the connection string (as specified in &lt;connectionStrings&gt; configuration section.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""connectionString"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Connection string. When provided, it overrides the values specified in DBHost, DBUserName, DBPassword, DBDatabase.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""dbHost"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Database host name. If the ConnectionString is not provided this value will be used to construct the ""Server="" part of the connection string.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""installConnectionString"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Connection string using for installation and uninstallation. If not provided, regular ConnectionString is being used.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""commandText"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Text of the SQL command to be run on each log level.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""commandType"" type=""System.Data.CommandType"">
          <xs:annotation>
            <xs:documentation>Type of the SQL command to be run on each log level.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""System.Data.CommandType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Text"" />
      <xs:enumeration value=""StoredProcedure"" />
      <xs:enumeration value=""TableDirect"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NLog.Targets.DatabaseCommandInfo"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""commandType"" type=""System.Data.CommandType"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""connectionString"" type=""Layout"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ignoreFailures"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.DatabaseParameterInfo"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""Layout"" />
    </xs:choice>
    <xs:attribute name=""commandType"" type=""System.Data.CommandType"">
      <xs:annotation>
        <xs:documentation>Type of the command.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""connectionString"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Connection string to run the command against. If not provided, connection string from the target is used.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""ignoreFailures"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Indicates whether to ignore failures.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""text"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Command text.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""NLog.Targets.DatabaseParameterInfo"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""precision"" type=""xs:byte"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""scale"" type=""xs:byte"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""size"" type=""xs:integer"" />
    </xs:choice>
    <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Layout that should be use to calcuate the value for the parameter.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""name"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Database parameter name.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""precision"" type=""xs:byte"">
      <xs:annotation>
        <xs:documentation>Database parameter precision.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""scale"" type=""xs:byte"">
      <xs:annotation>
        <xs:documentation>Database parameter scale.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""size"" type=""xs:integer"">
      <xs:annotation>
        <xs:documentation>Database parameter size.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""Debugger"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Text to be rendered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Debug"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""EventLog"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""category"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""entryType"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""eventId"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""log"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""machineName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxKilobytes"" type=""xs:long"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxMessageLength"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""source"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onOverflow"" type=""NLog.Targets.EventLogTargetOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""category"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout that renders event Category.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""entryType"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Optional entrytype. When not set, or when not convertable to  then determined by </xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""eventId"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout that renders event ID.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""log"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the Event Log to write to. This can be System, Application or any user-defined name.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""machineName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the machine on which Event Log service is running.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxKilobytes"" type=""xs:long"">
          <xs:annotation>
            <xs:documentation>Maximum Event log size in kilobytes. If null, the value won't be set. Default is 512 Kilobytes as specified by Eventlog API</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxMessageLength"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Message length limit to write to the Event Log.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""source"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Value to be used as the event Source.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onOverflow"" type=""NLog.Targets.EventLogTargetOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action to take if the message is larger than the  option.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.EventLogTargetOverflowAction"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Truncate"" />
      <xs:enumeration value=""Split"" />
      <xs:enumeration value=""Discard"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""FallbackGroup"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""CompoundTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""returnToFirstOnSuccess"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""returnToFirstOnSuccess"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to return to the first target after any successful write.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""File"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lineEnding"" type=""LineEndingMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""enableArchiveFileCompression"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveNumbering"" type=""NLog.Targets.ArchiveNumberingMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveFileName"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveFileKind"" type=""NLog.Targets.FilePathKind"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveEvery"" type=""NLog.Targets.FileArchivePeriod"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveAboveSize"" type=""xs:long"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxArchiveFiles"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""writeFooterOnArchivingOnly"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxLogFilenames"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""fileNameKind"" type=""NLog.Targets.FilePathKind"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""forceManaged"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""forceMutexConcurrentWrites"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""replaceFileContentsOnEachWrite"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""writeBom"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""enableFileDelete"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""fileName"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveDateFormat"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""archiveOldFileOnStartup"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""cleanupFileName"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""createDirs"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""deleteOldFileOnStartup"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""fileAttributes"" type=""NLog.Targets.Win32FileAttributes"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""networkWrites"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""openFileCacheTimeout"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""openFileCacheSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""keepFileOpen"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""discardAll"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""concurrentWrites"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""concurrentWriteAttempts"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""concurrentWriteAttemptDelay"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""bufferSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""openFileFlushTimeout"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""autoFlush"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Text to be rendered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>File encoding.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""lineEnding"" type=""LineEndingMode"">
          <xs:annotation>
            <xs:documentation>Line ending mode.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""enableArchiveFileCompression"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to compress archive files into the zip archive format.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveNumbering"" type=""NLog.Targets.ArchiveNumberingMode"">
          <xs:annotation>
            <xs:documentation>Way file archives are numbered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveFileName"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Name of the file to be used for an archive.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveFileKind"" type=""NLog.Targets.FilePathKind"">
          <xs:annotation>
            <xs:documentation>Is the  an absolute or relative path?</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveEvery"" type=""NLog.Targets.FileArchivePeriod"">
          <xs:annotation>
            <xs:documentation>Indicates whether to automatically archive log files every time the specified time passes.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveAboveSize"" type=""xs:long"">
          <xs:annotation>
            <xs:documentation>Size in bytes above which log files will be automatically archived. Warning: combining this with  isn't supported. We cannot create multiple archive files, if they should have the same name. Choose: </xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxArchiveFiles"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum number of archive files that should be kept.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""writeFooterOnArchivingOnly"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether the footer should be written only when the file is archived.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxLogFilenames"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum number of log filenames that should be stored as existing.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""fileNameKind"" type=""NLog.Targets.FilePathKind"">
          <xs:annotation>
            <xs:documentation>Is the  an absolute or relative path?</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""forceManaged"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Gets or set a value indicating whether a managed file stream is forced, instead of using the native implementation.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""forceMutexConcurrentWrites"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Value indicationg whether file creation calls should be synchronized by a system global mutex.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""replaceFileContentsOnEachWrite"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to replace file contents on each write instead of appending log message at the end.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""writeBom"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to write BOM (byte order mark) in created files</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""enableFileDelete"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to enable log file(s) to be deleted.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""fileName"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Name of the file to write to.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveDateFormat"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Value specifying the date format to use when archiving files.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""archiveOldFileOnStartup"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to archive old log file on startup.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""cleanupFileName"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Cleanup invalid values in a filename, e.g. slashes in a filename. If set to true, this can impact the performance of massive writes. If set to false, nothing gets written when the filename is wrong.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""createDirs"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to create directories if they do not exist.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""deleteOldFileOnStartup"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to delete old log file on startup.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""fileAttributes"" type=""NLog.Targets.Win32FileAttributes"">
          <xs:annotation>
            <xs:documentation>File attributes (Windows only).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""networkWrites"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether concurrent writes to the log file by multiple processes on different network hosts.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""openFileCacheTimeout"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum number of seconds that files are kept open. If this number is negative the files are not automatically closed after a period of inactivity.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""openFileCacheSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Number of files to be kept open. Setting this to a higher value may improve performance in a situation where a single File target is writing to many files (such as splitting by level or by logger).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""keepFileOpen"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to keep log file open instead of opening and closing it on each logging event.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""discardAll"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Whether or not this target should just discard all data that its asked to write. Mostly used for when testing NLog Stack except final write</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""concurrentWrites"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether concurrent writes to the log file by multiple processes on the same host.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""concurrentWriteAttempts"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Number of times the write is appended on the file before NLog discards the log message.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""concurrentWriteAttemptDelay"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Delay in milliseconds to wait before attempting to write to the file again.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""bufferSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Log file buffer size in bytes.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""openFileFlushTimeout"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum number of seconds before open files are flushed. If this number is negative or zero the files are not flushed by timer.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""autoFlush"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to automatically flush the file buffers after each log message.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.ArchiveNumberingMode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Sequence"" />
      <xs:enumeration value=""Rolling"" />
      <xs:enumeration value=""Date"" />
      <xs:enumeration value=""DateAndSequence"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.FilePathKind"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Unknown"" />
      <xs:enumeration value=""Relative"" />
      <xs:enumeration value=""Absolute"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.FileArchivePeriod"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Year"" />
      <xs:enumeration value=""Month"" />
      <xs:enumeration value=""Day"" />
      <xs:enumeration value=""Hour"" />
      <xs:enumeration value=""Minute"" />
      <xs:enumeration value=""Sunday"" />
      <xs:enumeration value=""Monday"" />
      <xs:enumeration value=""Tuesday"" />
      <xs:enumeration value=""Wednesday"" />
      <xs:enumeration value=""Thursday"" />
      <xs:enumeration value=""Friday"" />
      <xs:enumeration value=""Saturday"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.Win32FileAttributes"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ReadOnly"" />
      <xs:enumeration value=""Hidden"" />
      <xs:enumeration value=""System"" />
      <xs:enumeration value=""Archive"" />
      <xs:enumeration value=""Device"" />
      <xs:enumeration value=""Normal"" />
      <xs:enumeration value=""Temporary"" />
      <xs:enumeration value=""SparseFile"" />
      <xs:enumeration value=""ReparsePoint"" />
      <xs:enumeration value=""Compressed"" />
      <xs:enumeration value=""NotContentIndexed"" />
      <xs:enumeration value=""Encrypted"" />
      <xs:enumeration value=""WriteThrough"" />
      <xs:enumeration value=""NoBuffering"" />
      <xs:enumeration value=""DeleteOnClose"" />
      <xs:enumeration value=""PosixSemantics"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""FilteringWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""condition"" type=""Condition"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""condition"" type=""Condition"">
          <xs:annotation>
            <xs:documentation>Condition expression. Log events who meet this condition will be forwarded to the wrapped target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""ImpersonatingWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""domain"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""impersonationLevel"" type=""NLog.Targets.Wrappers.SecurityImpersonationLevel"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""logOnProvider"" type=""NLog.Targets.Wrappers.LogOnProviderType"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""logOnType"" type=""NLog.Targets.Wrappers.SecurityLogOnType"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""password"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""revertToSelf"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""userName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""domain"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Windows domain name to change context to.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""impersonationLevel"" type=""NLog.Targets.Wrappers.SecurityImpersonationLevel"">
          <xs:annotation>
            <xs:documentation>Required impersonation level.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""logOnProvider"" type=""NLog.Targets.Wrappers.LogOnProviderType"">
          <xs:annotation>
            <xs:documentation>Type of the logon provider.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""logOnType"" type=""NLog.Targets.Wrappers.SecurityLogOnType"">
          <xs:annotation>
            <xs:documentation>Logon Type.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""password"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>User account password.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""revertToSelf"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to revert to the credentials of the process instead of impersonating another user.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""userName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Username to change context to.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.Wrappers.SecurityImpersonationLevel"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Anonymous"" />
      <xs:enumeration value=""Identification"" />
      <xs:enumeration value=""Impersonation"" />
      <xs:enumeration value=""Delegation"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.Wrappers.LogOnProviderType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Default"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.Wrappers.SecurityLogOnType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Interactive"" />
      <xs:enumeration value=""Network"" />
      <xs:enumeration value=""Batch"" />
      <xs:enumeration value=""Service"" />
      <xs:enumeration value=""NetworkClearText"" />
      <xs:enumeration value=""NewCredentials"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""LimitingWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""interval"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""messageLimit"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""interval"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Interval in which messages will be written up to the  number of messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""messageLimit"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum allowed number of messages written per .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""LogReceiverService"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""endpointAddress"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""endpointConfigurationName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""useOneWayContract"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""clientId"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeEventProperties"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.MethodCallParameter"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""useBinaryEncoding"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""endpointAddress"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Endpoint address.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""endpointConfigurationName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the endpoint configuration in WCF configuration file.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""useOneWayContract"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to use a WCF service contract that is one way (fire and forget) or two way (request-reply)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""clientId"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Client ID.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeEventProperties"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include per-event properties in the payload sent to the server.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""useBinaryEncoding"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to use binary message encoding.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""NLog.Targets.MethodCallParameter"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""parameterType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""type"" type=""xs:string"" />
    </xs:choice>
    <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Layout that should be use to calculate the value for the parameter.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""name"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Name of the parameter.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""parameterType"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Type of the parameter.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""type"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Type of the parameter. Obsolete alias for </xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""Mail"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""replaceNewlineWithBrTagInHtml"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""priority"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""bcc"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""cc"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""addNewLines"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""html"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""from"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""body"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""subject"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""to"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""timeout"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""smtpServer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""smtpAuthentication"" type=""NLog.Targets.SmtpAuthenticationMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""smtpUserName"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""smtpPassword"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""enableSsl"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""smtpPort"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""useSystemNetMailSettings"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""pickupDirectoryLocation"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""deliveryMethod"" type=""System.Net.Mail.SmtpDeliveryMethod"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Text to be rendered.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""replaceNewlineWithBrTagInHtml"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether NewLine characters in the body should be replaced with  tags.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""priority"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Priority used for sending mails.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Encoding to be used for sending e-mail.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""bcc"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>BCC email addresses separated by semicolons (e.g. john@domain.com;jane@domain.com).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""cc"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>CC email addresses separated by semicolons (e.g. john@domain.com;jane@domain.com).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""addNewLines"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to add new lines between log entries.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""html"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to send message as HTML instead of plain text.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""from"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Sender's email address (e.g. joe@domain.com).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""body"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Mail message body (repeated for each log message send in one mail).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""subject"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Mail subject.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""to"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Recipients' email addresses separated by semicolons (e.g. john@domain.com;jane@domain.com).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""timeout"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Indicates the SMTP client timeout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""smtpServer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>SMTP Server to be used for sending.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""smtpAuthentication"" type=""NLog.Targets.SmtpAuthenticationMode"">
          <xs:annotation>
            <xs:documentation>SMTP Authentication mode.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""smtpUserName"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Username used to connect to SMTP server (used when SmtpAuthentication is set to ""basic"").</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""smtpPassword"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Password used to authenticate against SMTP server (used when SmtpAuthentication is set to ""basic"").</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""enableSsl"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether SSL (secure sockets layer) should be used when communicating with SMTP server.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""smtpPort"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Port number that SMTP Server is listening on.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""useSystemNetMailSettings"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether the default Settings from System.Net.MailSettings should be used.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""pickupDirectoryLocation"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Folder where applications save mail messages to be processed by the local SMTP server.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""deliveryMethod"" type=""System.Net.Mail.SmtpDeliveryMethod"">
          <xs:annotation>
            <xs:documentation>Specifies how outgoing email messages will be handled.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.SmtpAuthenticationMode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Basic"" />
      <xs:enumeration value=""Ntlm"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""System.Net.Mail.SmtpDeliveryMethod"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Network"" />
      <xs:enumeration value=""SpecifiedPickupDirectory"" />
      <xs:enumeration value=""PickupDirectoryFromIis"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""Memory"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""MethodCall"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""className"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""methodName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.MethodCallParameter"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""className"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Class name.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""methodName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Method name. The method must be public and static. Use the AssemblyQualifiedName , https://msdn.microsoft.com/en-us/library/system.type.assemblyqualifiedname(v=vs.110).aspx e.g.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Network"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lineEnding"" type=""LineEndingMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxMessageSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""newLine"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""address"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""connectionCacheSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""keepConnection"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxConnections"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxQueueSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onConnectionOverflow"" type=""NLog.Targets.NetworkTargetConnectionsOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onOverflow"" type=""NLog.Targets.NetworkTargetOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Encoding to be used.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""lineEnding"" type=""LineEndingMode"">
          <xs:annotation>
            <xs:documentation>End of line value if a newline is appended at the end of log message .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxMessageSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum message size in bytes.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""newLine"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to append newline at the end of log message.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""address"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Network address.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""connectionCacheSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Size of the connection cache (number of connections which are kept alive).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""keepConnection"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to keep connection open whenever possible.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxConnections"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum current connections. 0 = no maximum.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxQueueSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum queue size.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onConnectionOverflow"" type=""NLog.Targets.NetworkTargetConnectionsOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action that should be taken if the will be more connections than .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onOverflow"" type=""NLog.Targets.NetworkTargetOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action that should be taken if the message is larger than maxMessageSize.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""NLogViewer"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""lineEnding"" type=""LineEndingMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxMessageSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""newLine"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onConnectionOverflow"" type=""NLog.Targets.NetworkTargetConnectionsOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxQueueSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxConnections"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""keepConnection"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""connectionCacheSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""address"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""onOverflow"" type=""NLog.Targets.NetworkTargetOverflowAction"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.NLogViewerParameterInfo"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ndlcItemSeparator"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ndcItemSeparator"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNLogData"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeSourceInfo"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNdlc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdlc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeCallSite"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeAllProperties"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""appInfo"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""loggerName"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Encoding to be used.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Instance of  that is used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""lineEnding"" type=""LineEndingMode"">
          <xs:annotation>
            <xs:documentation>End of line value if a newline is appended at the end of log message .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxMessageSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum message size in bytes.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""newLine"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to append newline at the end of log message.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onConnectionOverflow"" type=""NLog.Targets.NetworkTargetConnectionsOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action that should be taken if the will be more connections than .</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxQueueSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum queue size.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxConnections"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Maximum current connections. 0 = no maximum.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""keepConnection"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to keep connection open whenever possible.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""connectionCacheSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Size of the connection cache (number of connections which are kept alive).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""address"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Network address.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""onOverflow"" type=""NLog.Targets.NetworkTargetOverflowAction"">
          <xs:annotation>
            <xs:documentation>Action that should be taken if the message is larger than maxMessageSize.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ndlcItemSeparator"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>NDLC item separator.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ndcItemSeparator"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>NDC item separator.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNLogData"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include NLog-specific extensions to log4j schema.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeSourceInfo"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include source info (file name and line number) in the information sent over the network.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  stack.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include  stack contents.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include  dictionary contents.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include  dictionary contents.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeCallSite"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include call site (class and method name) in the information sent over the network.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeAllProperties"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Option to include all properties from the log events</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""appInfo"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>AppInfo field. By default it's the friendly name of the current AppDomain.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""loggerName"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Renderer for log4j:event logger-xml-attribute (Default ${logger})</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Null"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""formatMessage"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""formatMessage"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to perform layout calculation.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""OutputDebugString"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""PerfCounter"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""autoCreate"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""categoryName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""counterHelp"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""counterName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""counterType"" type=""System.Diagnostics.PerformanceCounterType"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""incrementValue"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""instanceName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""autoCreate"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether performance counter should be automatically created.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""categoryName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the performance counter category.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""counterHelp"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Counter help text.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""counterName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the performance counter.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""counterType"" type=""System.Diagnostics.PerformanceCounterType"">
          <xs:annotation>
            <xs:documentation>Performance counter type.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""incrementValue"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>The value by which to increment the counter.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""instanceName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Performance counter instance name.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""System.Diagnostics.PerformanceCounterType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""NumberOfItems32"" />
      <xs:enumeration value=""NumberOfItems64"" />
      <xs:enumeration value=""NumberOfItemsHEX32"" />
      <xs:enumeration value=""NumberOfItemsHEX64"" />
      <xs:enumeration value=""RateOfCountsPerSecond32"" />
      <xs:enumeration value=""RateOfCountsPerSecond64"" />
      <xs:enumeration value=""CountPerTimeInterval32"" />
      <xs:enumeration value=""CountPerTimeInterval64"" />
      <xs:enumeration value=""RawFraction"" />
      <xs:enumeration value=""RawBase"" />
      <xs:enumeration value=""AverageTimer32"" />
      <xs:enumeration value=""AverageBase"" />
      <xs:enumeration value=""AverageCount64"" />
      <xs:enumeration value=""SampleFraction"" />
      <xs:enumeration value=""SampleCounter"" />
      <xs:enumeration value=""SampleBase"" />
      <xs:enumeration value=""CounterTimer"" />
      <xs:enumeration value=""CounterTimerInverse"" />
      <xs:enumeration value=""Timer100Ns"" />
      <xs:enumeration value=""Timer100NsInverse"" />
      <xs:enumeration value=""ElapsedTime"" />
      <xs:enumeration value=""CounterMultiTimer"" />
      <xs:enumeration value=""CounterMultiTimerInverse"" />
      <xs:enumeration value=""CounterMultiTimer100Ns"" />
      <xs:enumeration value=""CounterMultiTimer100NsInverse"" />
      <xs:enumeration value=""CounterMultiBase"" />
      <xs:enumeration value=""CounterDelta32"" />
      <xs:enumeration value=""CounterDelta64"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""PostFilteringWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""defaultFilter"" type=""Condition"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""when"" type=""NLog.Targets.Wrappers.FilteringRule"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""defaultFilter"" type=""Condition"">
          <xs:annotation>
            <xs:documentation>Default filter to be applied when no specific rule matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""NLog.Targets.Wrappers.FilteringRule"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""exists"" type=""Condition"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""filter"" type=""Condition"" />
    </xs:choice>
    <xs:attribute name=""exists"" type=""Condition"">
      <xs:annotation>
        <xs:documentation>Condition to be tested.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""filter"" type=""Condition"">
      <xs:annotation>
        <xs:documentation>Resulting filter to be applied when the condition matches.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""RandomizeGroup"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""CompoundTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""RepeatingWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""repeatCount"" type=""xs:integer"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""repeatCount"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Number of times to repeat each log message.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""RetryingWrapper"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""WrapperTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""retryCount"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""retryDelayMilliseconds"" type=""xs:integer"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""retryCount"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Number of retries that should be attempted on the wrapped target in case of a failure.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""retryDelayMilliseconds"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Time to wait between retries in milliseconds.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""RoundRobinGroup"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""CompoundTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SplitGroup"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""CompoundTargetBase"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Trace"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""rawWrite"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout used to format log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""rawWrite"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Always use  independent of </xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""WebService"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Target"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""parameter"" type=""NLog.Targets.MethodCallParameter"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeBOM"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""methodName"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""namespace"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""protocol"" type=""NLog.Targets.WebServiceProtocol"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""proxyAddress"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encoding"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""url"" type=""xs:anyURI"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""escapeDataNLogLegacy"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""escapeDataRfc3986"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""preAuthenticate"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""xmlRoot"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""xmlRootNamespace"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""header"" type=""NLog.Targets.MethodCallParameter"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""proxyType"" type=""NLog.Targets.WebServiceProxyType"" />
        </xs:choice>
        <xs:attribute name=""name"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the target.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Target supports reuse of internal buffers, and doesn't have to constantly allocate new buffers Required for legacy NLog-targets, that expects buffers to remain stable after Write-method exit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeBOM"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Should we include the BOM (Byte-order-mark) for UTF? Influences the  property. This will only work for UTF-8.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""methodName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Web service method name. Only used with Soap.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""namespace"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Web service namespace. Only used with Soap.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""protocol"" type=""NLog.Targets.WebServiceProtocol"">
          <xs:annotation>
            <xs:documentation>Protocol to be used when calling web service.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""proxyAddress"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Custom proxy address, include port separated by a colon</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""encoding"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Encoding.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""url"" type=""xs:anyURI"">
          <xs:annotation>
            <xs:documentation>Web service URL.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""escapeDataNLogLegacy"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Value whether escaping be done according to the old NLog style (Very non-standard)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""escapeDataRfc3986"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Value whether escaping be done according to Rfc3986 (Supports Internationalized Resource Identifiers - IRIs)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""preAuthenticate"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to pre-authenticate the HttpWebRequest (Requires 'Authorization' in  parameters)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""xmlRoot"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Name of the root XML element, if POST of XML document chosen. If so, this property must not be null. (see  and ).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""xmlRootNamespace"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>(optional) root namespace of the XML document, if POST of XML document chosen. (see  and ).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""proxyType"" type=""NLog.Targets.WebServiceProxyType"">
          <xs:annotation>
            <xs:documentation>Proxy configuration when calling web service</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Targets.WebServiceProtocol"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Soap11"" />
      <xs:enumeration value=""Soap12"" />
      <xs:enumeration value=""HttpPost"" />
      <xs:enumeration value=""HttpGet"" />
      <xs:enumeration value=""JsonPost"" />
      <xs:enumeration value=""XmlPost"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Targets.WebServiceProxyType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DefaultWebProxy"" />
      <xs:enumeration value=""AutoProxy"" />
      <xs:enumeration value=""NoProxy"" />
      <xs:enumeration value=""ProxyAddress"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""CompoundLayout"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Layout"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""layout"" type=""Layout"" />
        </xs:choice>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Layout"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"" />
  </xs:complexType>
  <xs:complexType name=""CsvLayout"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Layout"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""column"" type=""NLog.Layouts.CsvColumn"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""customColumnDelimiter"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""delimiter"" type=""NLog.Layouts.CsvColumnDelimiterMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""quoteChar"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""quoting"" type=""NLog.Layouts.CsvQuotingMode"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""withHeader"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer layout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header layout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Body layout (can be repeated multiple times).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""customColumnDelimiter"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Custom column delimiter value (valid when ColumnDelimiter is set to 'Custom').</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""delimiter"" type=""NLog.Layouts.CsvColumnDelimiterMode"">
          <xs:annotation>
            <xs:documentation>Column delimiter.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""quoteChar"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Quote Character.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""quoting"" type=""NLog.Layouts.CsvQuotingMode"">
          <xs:annotation>
            <xs:documentation>Quoting mode.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""withHeader"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether CVS should include header.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""NLog.Layouts.CsvColumnDelimiterMode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Auto"" />
      <xs:enumeration value=""Comma"" />
      <xs:enumeration value=""Semicolon"" />
      <xs:enumeration value=""Tab"" />
      <xs:enumeration value=""Pipe"" />
      <xs:enumeration value=""Space"" />
      <xs:enumeration value=""Custom"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""NLog.Layouts.CsvQuotingMode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""All"" />
      <xs:enumeration value=""Nothing"" />
      <xs:enumeration value=""Auto"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""NLog.Layouts.CsvColumn"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
    </xs:choice>
    <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Layout of the column.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""name"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Name of the column.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""JsonLayout"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Layout"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""attribute"" type=""NLog.Layouts.JsonAttribute"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""excludeProperties"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeAllProperties"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdlc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""renderEmptyObject"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""suppressSpaces"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxRecursionLimit"" type=""xs:integer"" />
        </xs:choice>
        <xs:attribute name=""excludeProperties"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>List of property names to exclude when  is true</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeAllProperties"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Option to include all properties from the log event (as JSON)</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  dictionary.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  dictionary.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""renderEmptyObject"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Option to render the empty object value {}</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""suppressSpaces"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Option to suppress the extra spaces in the output json</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxRecursionLimit"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>How far should the JSON serializer follow object references before backing off</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""NLog.Layouts.JsonAttribute"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""name"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""encode"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""escapeUnicode"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeEmptyValue"" type=""xs:boolean"" />
    </xs:choice>
    <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
      <xs:annotation>
        <xs:documentation>Layout that will be rendered as the attribute's value.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""name"" type=""xs:string"">
      <xs:annotation>
        <xs:documentation>Name of the attribute.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""encode"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Determines wether or not this attribute will be Json encoded.</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""escapeUnicode"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Indicates whether to escape non-ascii characters</xs:documentation>
      </xs:annotation>
    </xs:attribute>
    <xs:attribute name=""includeEmptyValue"" type=""xs:boolean"">
      <xs:annotation>
        <xs:documentation>Whether an attribute with empty value should be included in the output</xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""LayoutWithHeaderAndFooter"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Layout"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""footer"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""header"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
        </xs:choice>
        <xs:attribute name=""footer"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Footer layout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""header"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Header layout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Body layout (can be repeated multiple times).</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""Log4JXmlEventLayout"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Layout"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeAllProperties"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeMdlc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNdc"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeNdlc"" type=""xs:boolean"" />
        </xs:choice>
        <xs:attribute name=""includeAllProperties"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Option to include all properties from the log events</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  dictionary.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeMdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  dictionary.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNdc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  stack.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeNdlc"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to include contents of the  stack.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SimpleLayout"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Layout"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""text"" type=""xs:string"" />
        </xs:choice>
        <xs:attribute name=""text"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Layout text.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""when"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Filter"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""action"" type=""FilterResult"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""condition"" type=""Condition"" />
        </xs:choice>
        <xs:attribute name=""action"" type=""FilterResult"">
          <xs:annotation>
            <xs:documentation>Action to be taken when filter matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""condition"" type=""Condition"">
          <xs:annotation>
            <xs:documentation>Condition expression.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:simpleType name=""FilterResult"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Neutral"" />
      <xs:enumeration value=""Log"" />
      <xs:enumeration value=""Ignore"" />
      <xs:enumeration value=""LogFinal"" />
      <xs:enumeration value=""IgnoreFinal"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""whenContains"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Filter"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""action"" type=""FilterResult"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ignoreCase"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""substring"" type=""xs:string"" />
        </xs:choice>
        <xs:attribute name=""action"" type=""FilterResult"">
          <xs:annotation>
            <xs:documentation>Action to be taken when filter matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ignoreCase"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to ignore case when comparing strings.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout to be used to filter log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""substring"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Substring to be matched.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""whenEqual"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Filter"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""action"" type=""FilterResult"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""compareTo"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ignoreCase"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
        </xs:choice>
        <xs:attribute name=""action"" type=""FilterResult"">
          <xs:annotation>
            <xs:documentation>Action to be taken when filter matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""compareTo"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>String to compare the layout to.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ignoreCase"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to ignore case when comparing strings.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout to be used to filter log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""whenNotContains"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Filter"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""action"" type=""FilterResult"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ignoreCase"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""substring"" type=""xs:string"" />
        </xs:choice>
        <xs:attribute name=""action"" type=""FilterResult"">
          <xs:annotation>
            <xs:documentation>Action to be taken when filter matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ignoreCase"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to ignore case when comparing strings.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout to be used to filter log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""substring"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Substring to be matched.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""whenNotEqual"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Filter"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""action"" type=""FilterResult"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""compareTo"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ignoreCase"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
        </xs:choice>
        <xs:attribute name=""action"" type=""FilterResult"">
          <xs:annotation>
            <xs:documentation>Action to be taken when filter matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""compareTo"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>String to compare the layout to.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""ignoreCase"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Indicates whether to ignore case when comparing strings.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout to be used to filter log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""whenRepeated"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""Filter"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""action"" type=""FilterResult"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""defaultFilterCacheSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""includeFirst"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""layout"" type=""Layout"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxFilterCacheSize"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""maxLength"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""timeoutSeconds"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferDefaultLength"" type=""xs:integer"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""optimizeBufferReuse"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""filterCountMessageAppendFormat"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""filterCountPropertyName"" type=""xs:string"" />
        </xs:choice>
        <xs:attribute name=""action"" type=""FilterResult"">
          <xs:annotation>
            <xs:documentation>Action to be taken when filter matches.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""defaultFilterCacheSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Default number of unique filter values to expect, will automatically increase if needed</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""includeFirst"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Applies the configured action to the initial logevent that starts the timeout period. Used to configure that it should ignore all events until timeout.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""layout"" type=""SimpleLayoutAttribute"">
          <xs:annotation>
            <xs:documentation>Layout to be used to filter log messages.</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxFilterCacheSize"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Max number of unique filter values to expect simultaneously</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""maxLength"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Max length of filter values, will truncate if above limit</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""timeoutSeconds"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>How long before a filter expires, and logging is accepted again</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferDefaultLength"" type=""xs:integer"">
          <xs:annotation>
            <xs:documentation>Default buffer size for the internal buffers</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""optimizeBufferReuse"" type=""xs:boolean"">
          <xs:annotation>
            <xs:documentation>Reuse internal buffers, and doesn't have to constantly allocate new buffers</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""filterCountMessageAppendFormat"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Append FilterCount to the  when an event is no longer filtered</xs:documentation>
          </xs:annotation>
        </xs:attribute>
        <xs:attribute name=""filterCountPropertyName"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>Insert FilterCount value into  when an event is no longer filtered</xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""AccurateLocal"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""TimeSource"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""AccurateUTC"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""TimeSource"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""FastLocal"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""TimeSource"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""FastUTC"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""TimeSource"">
        <xs:choice minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
</xs:schema>";
        
        public NLog() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "nlog";
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
