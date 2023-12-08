<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="ced55abc-6d18-423a-8d79-f66f713f3f11" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWeb" Name="PLFLARCCAYRClassWeb" DisplayName="PLFLARCCAYRClassWeb" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" ProductName="PLFLARCCAYRClassWeb" CompanyName="UPM_IPS" PackageGuid="e5ddda47-db2a-44bd-b11f-fd632c9c19e4" PackageNamespace="UPM_IPS.PLFLARCCAYRClassWeb" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="771f4483-dc3d-49c4-88b5-724f8fe873ae" Description="The root in which all other elements are embedded. Appears as a diagram." Name="Tapiz" DisplayName="Tapiz" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
      <Properties>
        <DomainProperty Id="d620de4d-5b6c-4e15-a10c-415e093351bd" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Tapiz.Nombre Solucion" Name="nombreSolucion" DisplayName="Nombre Solucion">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Clase" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>TapizHasClases.Clases</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="dd3ddda3-ecd0-4c39-8d99-146c19b24d7a" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Elemento" Name="Elemento" DisplayName="Elemento" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
      <Properties>
        <DomainProperty Id="29863726-28fa-471c-a5bd-4b5ffb5c9af0" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Elemento.Nombre" Name="nombre" DisplayName="Nombre">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="485133f5-5223-4cf8-b946-0975c87243ee" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Elemento.Tipo Dato" Name="tipoDato" DisplayName="Tipo Dato">
          <Type>
            <DomainEnumerationMoniker Name="TipoDato" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="8025a992-be47-444d-9759-11ff6497a180" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Elemento.Nombre Tipo Calculada" Name="nombreTipoCalculada" DisplayName="Nombre Tipo Calculada" Kind="Calculated" IsBrowsable="false" IsUIReadOnly="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="bb1a8246-8c36-49b4-96d6-7c79244eaeba" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Clase" Name="Clase" DisplayName="Clase" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
      <Properties>
        <DomainProperty Id="dd35a559-221c-4e8d-a665-bf1ecb088b2f" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Clase.Nombre" Name="nombre" DisplayName="Nombre">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="caf5e179-6e63-400e-868c-1e6e5383b656" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Clase.Id" Name="id" DisplayName="Id">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Atributo" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ClaseHasAtributo.Atributo</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Operacion" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ClaseHasOperacioned.Operacioned</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="fce932bb-16b2-47ba-bffd-a3b9fa6a9b2b" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Atributo" Name="Atributo" DisplayName="Atributo" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
      <BaseClass>
        <DomainClassMoniker Name="Elemento" />
      </BaseClass>
    </DomainClass>
    <DomainClass Id="2aa3a50f-d907-40d1-b430-e42e9312f2b6" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Operacion" Name="Operacion" DisplayName="Operacion" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
      <BaseClass>
        <DomainClassMoniker Name="Elemento" />
      </BaseClass>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Parametros" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>OperacionHasParametro.Parametro</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="192143cd-a717-47e9-83cf-e1fd0f341de9" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.Parametros" Name="Parametros" DisplayName="Parametros" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
      <BaseClass>
        <DomainClassMoniker Name="Elemento" />
      </BaseClass>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="26121035-877c-4adf-95cb-02590d87a626" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TapizHasClases" Name="TapizHasClases" DisplayName="Tapiz Has Clases" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" IsEmbedding="true">
      <Source>
        <DomainRole Id="063ba5cd-0c13-4ae8-961e-2079e5eaddb2" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TapizHasClases.Tapiz" Name="Tapiz" DisplayName="Tapiz" PropertyName="Clases" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Clases">
          <RolePlayer>
            <DomainClassMoniker Name="Tapiz" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="01613520-bd70-47a1-a3ec-f9e549d381c1" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TapizHasClases.Clase" Name="Clase" DisplayName="Clase" PropertyName="Tapiz" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Tapiz">
          <RolePlayer>
            <DomainClassMoniker Name="Clase" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="7f86b8f2-d708-4e2c-a259-a908feed5230" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo" Name="ClaseHasAtributo" DisplayName="Clase Has Atributo" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" IsEmbedding="true">
      <Source>
        <DomainRole Id="154e9a90-390f-4026-9766-687d15c8e98d" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo.Clase" Name="Clase" DisplayName="Clase" PropertyName="Atributo" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Atributo">
          <RolePlayer>
            <DomainClassMoniker Name="Clase" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="5e789619-de4e-4d8a-95a1-6035afc5d525" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo.Atributo" Name="Atributo" DisplayName="Atributo" PropertyName="Clase" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Clase">
          <RolePlayer>
            <DomainClassMoniker Name="Atributo" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="71f3866f-76f4-43b4-b07a-d551efaeff5d" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasOperacioned" Name="ClaseHasOperacioned" DisplayName="Clase Has Operacioned" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" IsEmbedding="true">
      <Source>
        <DomainRole Id="06dca603-956b-49dc-adcd-8482dcd9e7f4" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasOperacioned.Clase" Name="Clase" DisplayName="Clase" PropertyName="Operacioned" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Operacioned">
          <RolePlayer>
            <DomainClassMoniker Name="Clase" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="bbc457e4-8502-4d72-80a4-b451ab1170ea" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasOperacioned.Operacion" Name="Operacion" DisplayName="Operacion" PropertyName="Clase" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Clase">
          <RolePlayer>
            <DomainClassMoniker Name="Operacion" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="24b1bfff-a221-46f5-bb4c-7c8378809b07" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro" Name="OperacionHasParametro" DisplayName="Operacion Has Parametro" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" IsEmbedding="true">
      <Source>
        <DomainRole Id="19c1a29e-11bc-40dd-983d-7c117b07848b" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro.Operacion" Name="Operacion" DisplayName="Operacion" PropertyName="Parametro" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Parametro">
          <RolePlayer>
            <DomainClassMoniker Name="Operacion" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="3538d235-c83a-4906-b43d-597564647fa0" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro.Parametros" Name="Parametros" DisplayName="Parametros" PropertyName="Operacion" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Operacion">
          <RolePlayer>
            <DomainClassMoniker Name="Parametros" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="TipoDato" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato">
      <Literals>
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Byte" Name="Byte" Value="0" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Short" Name="Short" Value="1" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Int" Name="Int" Value="3" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Long" Name="Long" Value="4" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Float" Name="Float" Value="5" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Double" Name="Double" Value="6" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Char" Name="Char" Value="7" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.Boolean" Name="Boolean" Value="8" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato.String" Name="String" Value="9" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="TipoDato1" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1">
      <Literals>
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Byte" Name="Byte" Value="0" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Short" Name="Short" Value="1" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Int" Name="Int" Value="3" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Long" Name="Long" Value="4" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Float" Name="Float" Value="5" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Double" Name="Double" Value="6" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Char" Name="Char" Value="7" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.Boolean" Name="Boolean" Value="8" />
        <EnumerationLiteral Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.TipoDato1.String" Name="String" Value="9" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <CompartmentShape Id="9b2d8381-2531-433f-97fe-9fa7d83c1802" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase" Name="MetaforaClase" DisplayName="Metafora Clase" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" FixedTooltipText="Metafora Clase" FillColor="LightSteelBlue" OutlineColor="SteelBlue" InitialHeight="1" FillGradientMode="None" Geometry="RoundedRectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="nombreClaseDec" DisplayName="Nombre Clase Dec" DefaultText="nombreClaseDec" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="idDec" DisplayName="Id Dec" DefaultText="idDec" />
      </ShapeHasDecorators>
      <Compartment FillColor="LightSteelBlue" TitleFillColor="LightSteelBlue" Name="AtrCompartment" />
    </CompartmentShape>
    <CompartmentShape Id="6c6a8f46-ca96-445b-b302-edae3a7ebeae" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion" Name="MetaforaOperacion" DisplayName="Metafora Operacion" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" FixedTooltipText="Metafora Operacion" FillColor="Lavender" OutlineColor="RoyalBlue" InitialHeight="1" FillGradientMode="None" Geometry="RoundedRectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="nombreOpDec" DisplayName="Nombre Op Dec" DefaultText="nombreOpDec" />
      </ShapeHasDecorators>
      <Compartment FillColor="Lavender" TitleFillColor="Lavender" Name="ParamCompartment" />
    </CompartmentShape>
  </Shapes>
  <XmlSerializationBehavior Name="PLFLARCCAYRClassWebSerializationBehavior" Namespace="UPM_IPS.PLFLARCCAYRClassWeb">
    <ClassData>
      <XmlClassData TypeName="Tapiz" MonikerAttributeName="" SerializeId="true" MonikerElementName="tapizMoniker" ElementName="tapiz" MonikerTypeName="TapizMoniker">
        <DomainClassMoniker Name="Tapiz" />
        <ElementData>
          <XmlPropertyData XmlName="nombreSolucion">
            <DomainPropertyMoniker Name="Tapiz/nombreSolucion" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="clases">
            <DomainRelationshipMoniker Name="TapizHasClases" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="PLFLARCCAYRClassWebDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="pLFLARCCAYRClassWebDiagramMoniker" ElementName="pLFLARCCAYRClassWebDiagram" MonikerTypeName="PLFLARCCAYRClassWebDiagramMoniker">
        <DiagramMoniker Name="PLFLARCCAYRClassWebDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Elemento" MonikerAttributeName="" SerializeId="true" MonikerElementName="elementoMoniker" ElementName="elemento" MonikerTypeName="ElementoMoniker">
        <DomainClassMoniker Name="Elemento" />
        <ElementData>
          <XmlPropertyData XmlName="nombre">
            <DomainPropertyMoniker Name="Elemento/nombre" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="tipoDato">
            <DomainPropertyMoniker Name="Elemento/tipoDato" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="nombreTipoCalculada" Representation="Ignore">
            <DomainPropertyMoniker Name="Elemento/nombreTipoCalculada" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Clase" MonikerAttributeName="" SerializeId="true" MonikerElementName="claseMoniker" ElementName="clase" MonikerTypeName="ClaseMoniker">
        <DomainClassMoniker Name="Clase" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="atributo">
            <DomainRelationshipMoniker Name="ClaseHasAtributo" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="operacioned">
            <DomainRelationshipMoniker Name="ClaseHasOperacioned" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="nombre">
            <DomainPropertyMoniker Name="Clase/nombre" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="id">
            <DomainPropertyMoniker Name="Clase/id" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="TapizHasClases" MonikerAttributeName="" SerializeId="true" MonikerElementName="tapizHasClasesMoniker" ElementName="tapizHasClases" MonikerTypeName="TapizHasClasesMoniker">
        <DomainRelationshipMoniker Name="TapizHasClases" />
      </XmlClassData>
      <XmlClassData TypeName="Atributo" MonikerAttributeName="" SerializeId="true" MonikerElementName="atributoMoniker" ElementName="atributo" MonikerTypeName="AtributoMoniker">
        <DomainClassMoniker Name="Atributo" />
      </XmlClassData>
      <XmlClassData TypeName="Operacion" MonikerAttributeName="" SerializeId="true" MonikerElementName="operacionMoniker" ElementName="operacion" MonikerTypeName="OperacionMoniker">
        <DomainClassMoniker Name="Operacion" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="parametro">
            <DomainRelationshipMoniker Name="OperacionHasParametro" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ClaseHasAtributo" MonikerAttributeName="" SerializeId="true" MonikerElementName="claseHasAtributoMoniker" ElementName="claseHasAtributo" MonikerTypeName="ClaseHasAtributoMoniker">
        <DomainRelationshipMoniker Name="ClaseHasAtributo" />
      </XmlClassData>
      <XmlClassData TypeName="ClaseHasOperacioned" MonikerAttributeName="" SerializeId="true" MonikerElementName="claseHasOperacionedMoniker" ElementName="claseHasOperacioned" MonikerTypeName="ClaseHasOperacionedMoniker">
        <DomainRelationshipMoniker Name="ClaseHasOperacioned" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaClase" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaClaseMoniker" ElementName="metaforaClase" MonikerTypeName="MetaforaClaseMoniker">
        <CompartmentShapeMoniker Name="MetaforaClase" />
      </XmlClassData>
      <XmlClassData TypeName="Parametros" MonikerAttributeName="" SerializeId="true" MonikerElementName="parametrosMoniker" ElementName="parametros" MonikerTypeName="ParametrosMoniker">
        <DomainClassMoniker Name="Parametros" />
      </XmlClassData>
      <XmlClassData TypeName="OperacionHasParametro" MonikerAttributeName="" SerializeId="true" MonikerElementName="operacionHasParametroMoniker" ElementName="operacionHasParametro" MonikerTypeName="OperacionHasParametroMoniker">
        <DomainRelationshipMoniker Name="OperacionHasParametro" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaOperacion" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaOperacionMoniker" ElementName="metaforaOperacion" MonikerTypeName="MetaforaOperacionMoniker">
        <CompartmentShapeMoniker Name="MetaforaOperacion" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="PLFLARCCAYRClassWebExplorer" />
  <Diagram Id="4861cff9-a103-4745-a9dd-72e309bf7324" Description="Description for UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDiagram" Name="PLFLARCCAYRClassWebDiagram" DisplayName="Minimal Language Diagram" Namespace="UPM_IPS.PLFLARCCAYRClassWeb" FillColor="AliceBlue">
    <Class>
      <DomainClassMoniker Name="Tapiz" />
    </Class>
    <ShapeMaps>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Clase" />
        <ParentElementPath>
          <DomainPath>TapizHasClases.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="MetaforaClase/nombreClaseDec" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Clase/nombre" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="MetaforaClase/idDec" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Clase/id" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="MetaforaClase" />
        <CompartmentMap>
          <CompartmentMoniker Name="MetaforaClase/AtrCompartment" />
          <ElementsDisplayed>
            <DomainPath>ClaseHasAtributo.Atributo/!Atributo</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Elemento/nombreTipoCalculada" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
      </CompartmentShapeMap>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Operacion" />
        <ParentElementPath>
          <DomainPath>ClaseHasOperacioned.Clase/!Clase/TapizHasClases.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <CompartmentShapeMoniker Name="MetaforaOperacion" />
        <CompartmentMap>
          <CompartmentMoniker Name="MetaforaOperacion/ParamCompartment" />
          <ElementsDisplayed>
            <DomainPath>OperacionHasParametro.Parametro/!Parametros</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Elemento/nombreTipoCalculada" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
      </CompartmentShapeMap>
    </ShapeMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="PLFLARCCAYR_DSLClassWeb" EditorGuid="a59eef72-a1e0-4275-b086-30b7b49fcf8d">
    <RootClass>
      <DomainClassMoniker Name="Tapiz" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="PLFLARCCAYRClassWebSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="PLFLARCCAYRClassWeb">
      <ElementTool Name="ClaseTool" ToolboxIcon="Resources\c.bmp" Caption="Clase" Tooltip="Crea una clase" HelpKeyword="ClaseTool">
        <DomainClassMoniker Name="Clase" />
      </ElementTool>
      <ElementTool Name="AtributoTool" ToolboxIcon="Resources\A.bmp" Caption="Atributo" Tooltip="Crea un atributo" HelpKeyword="AtributoTool">
        <DomainClassMoniker Name="Atributo" />
      </ElementTool>
      <ElementTool Name="OperacionTool" ToolboxIcon="Resources\o.bmp" Caption="Operacion" Tooltip="Crea una operacion" HelpKeyword="OperacionTool">
        <DomainClassMoniker Name="Operacion" />
      </ElementTool>
      <ElementTool Name="ParametroTool" ToolboxIcon="Resources\p.bmp" Caption="Parametro" Tooltip="Crea un parametro" HelpKeyword="ParametroTool">
        <DomainClassMoniker Name="Parametros" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="PLFLARCCAYRClassWebDiagram" />
  </Designer>
  <Explorer ExplorerGuid="8edc0750-d54a-4278-8a8b-4574b451151d" Title="PLFLARCCAYRClassWeb Explorer">
    <ExplorerBehaviorMoniker Name="PLFLARCCAYRClassWeb/PLFLARCCAYRClassWebExplorer" />
  </Explorer>
</Dsl>