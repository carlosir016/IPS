﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

[module: global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDiagram")]

namespace UPM_IPS.PLFLARCCAYRClassWeb
{
	/// <summary>
	/// DomainClass PLFLARCCAYRClassWebDiagram
	/// Description for UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDiagram
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDiagram.DisplayName", typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDomainModel), "UPM_IPS.PLFLARCCAYRClassWeb.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDiagram.Description", typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDomainModel), "UPM_IPS.PLFLARCCAYRClassWeb.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("4861cff9-a103-4745-a9dd-72e309bf7324")]
	public partial class PLFLARCCAYRClassWebDiagram : DslDiagrams::Diagram
	{
		#region Diagram boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		#endregion
		#region Toolbox filters
		private static global::System.ComponentModel.ToolboxItemFilterAttribute[] toolboxFilters = new global::System.ComponentModel.ToolboxItemFilterAttribute[] {
					new global::System.ComponentModel.ToolboxItemFilterAttribute(global::UPM_IPS.PLFLARCCAYRClassWeb.PLFLARCCAYRClassWebToolboxHelperBase.ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) };
		
		/// <summary>
		/// Toolbox item filter attributes for this diagram.
		/// </summary>
		public override global::System.Collections.ICollection TargetToolboxItemFilterAttributes
		{
			get
			{
				return toolboxFilters;
			}
		}
		#endregion
		#region Diagram styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Fill brush settings for this shape.
			DslDiagrams::BrushSettings backgroundBrush = new DslDiagrams::BrushSettings();
			backgroundBrush.Color = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.AliceBlue);
			classStyleSet.OverrideBrush(DslDiagrams::DiagramBrushes.DiagramBackground, backgroundBrush);
		
		}
		#endregion
		#region Auto-placement
		/// <summary>
		/// Indicate that child shapes should added through view fixup should be placed automatically.
		/// </summary>
		public override bool ShouldAutoPlaceChildShapes
		{
			get
			{
				return true;
			}
		}
		#endregion
		#region Compartment support
		/// <summary>
		/// Whether compartment items change events are subscribed to.
		/// </summary>
		private bool subscribedCompartmentItemsEvents;
		
		/// <summary>
		/// Subscribe to events fired when compartment items changes.
		/// </summary>
		public void SubscribeCompartmentItemsEvents()
		{
			if (!subscribedCompartmentItemsEvents && this.Store != null)
			{
				subscribedCompartmentItemsEvents = true;
				this.Store.EventManagerDirectory.ElementAdded.Add(new global::System.EventHandler<DslModeling::ElementAddedEventArgs>(this.CompartmentItemAdded));
				this.Store.EventManagerDirectory.ElementDeleted.Add(new global::System.EventHandler<DslModeling::ElementDeletedEventArgs>(this.CompartmentItemDeleted));
				this.Store.EventManagerDirectory.ElementPropertyChanged.Add(new global::System.EventHandler<DslModeling::ElementPropertyChangedEventArgs>(this.CompartmentItemPropertyChanged));
				this.Store.EventManagerDirectory.RolePlayerChanged.Add(new global::System.EventHandler<DslModeling::RolePlayerChangedEventArgs>(this.CompartmentItemRolePlayerChanged));
				this.Store.EventManagerDirectory.RolePlayerOrderChanged.Add(new global::System.EventHandler<DslModeling::RolePlayerOrderChangedEventArgs>(this.CompartmentItemRolePlayerOrderChanged));
			}
		}
		
		/// <summary>
		/// Unsubscribe to events fired when compartment items changes.
		/// </summary>
		public void UnsubscribeCompartmentItemsEvents()
		{
			if (subscribedCompartmentItemsEvents)
			{
				this.Store.EventManagerDirectory.ElementAdded.Remove(new global::System.EventHandler<DslModeling::ElementAddedEventArgs>(this.CompartmentItemAdded));
				this.Store.EventManagerDirectory.ElementDeleted.Remove(new global::System.EventHandler<DslModeling::ElementDeletedEventArgs>(this.CompartmentItemDeleted));
				this.Store.EventManagerDirectory.ElementPropertyChanged.Remove(new global::System.EventHandler<DslModeling::ElementPropertyChangedEventArgs>(this.CompartmentItemPropertyChanged));
				this.Store.EventManagerDirectory.RolePlayerChanged.Remove(new global::System.EventHandler<DslModeling::RolePlayerChangedEventArgs>(this.CompartmentItemRolePlayerChanged));
				this.Store.EventManagerDirectory.RolePlayerOrderChanged.Remove(new global::System.EventHandler<DslModeling::RolePlayerOrderChangedEventArgs>(this.CompartmentItemRolePlayerOrderChanged));
				subscribedCompartmentItemsEvents = false;
			}
		}
		
		#region Event handlers
		/// <summary>
		/// Event for element added.
		/// </summary>
		private void CompartmentItemAdded(object sender, DslModeling::ElementAddedEventArgs e)
		{
			// If in Undo, Redo or Rollback the compartment item rules are not run so we must refresh the compartment list at this point if required
			bool repaintOnly = !e.ModelElement.Store.InUndoRedoOrRollback;
			CompartmentItemAddRule.ElementAdded(e, repaintOnly);
		}
		/// <summary>
		/// Event for element deleted.
		/// </summary>
		private void CompartmentItemDeleted(object sender, DslModeling::ElementDeletedEventArgs e)
		{
			bool repaintOnly = !e.ModelElement.Store.InUndoRedoOrRollback;
			CompartmentItemDeleteRule.ElementDeleted(e, repaintOnly);
		}
		/// <summary>
		/// Event for element property changed.
		/// </summary>
		private void CompartmentItemPropertyChanged(object sender, DslModeling::ElementPropertyChangedEventArgs e)
		{
			bool repaintOnly = !e.ModelElement.Store.InUndoRedoOrRollback;
			CompartmentItemChangeRule.ElementPropertyChanged(e, repaintOnly);
		}
		/// <summary>
		/// Event for role-player changed.
		/// </summary>
		private void CompartmentItemRolePlayerChanged(object sender, DslModeling::RolePlayerChangedEventArgs e)
		{
			bool repaintOnly = !e.ElementLink.Store.InUndoRedoOrRollback;
			CompartmentItemRolePlayerChangeRule.RolePlayerChanged(e, repaintOnly);
		}
		/// <summary>
		/// Event for role-player order changed.
		/// </summary>
		private void CompartmentItemRolePlayerOrderChanged(object sender, DslModeling::RolePlayerOrderChangedEventArgs e)
		{
			bool repaintOnly = !e.Link.Store.InUndoRedoOrRollback;
			CompartmentItemRolePlayerPositionChangeRule.RolePlayerPositionChanged(e, repaintOnly);
		}
		#endregion
		#endregion
		#region Shape mapping
		/// <summary>
		/// Called during view fixup to ask the parent whether a shape should be created for the given child element.
		/// </summary>
		/// <remarks>
		/// Always return true, since we assume there is only one diagram per model file for DSL scenarios.
		/// </remarks>
		protected override bool ShouldAddShapeForElement(DslModeling::ModelElement element)
		{
			return true;
		}
		
		
		/// <summary>
		/// Creates a new shape for the given model element as part of view fixup
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Justification = "Generated code.")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
		protected override DslDiagrams::ShapeElement CreateChildShape(DslModeling::ModelElement element)
		{
			if(element is global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion)
			{
				global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion newShape = new global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion(this.Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			if(element is global::UPM_IPS.PLFLARCCAYRClassWeb.Clase)
			{
				global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase newShape = new global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase(this.Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			return base.CreateChildShape(element);
		}
		#endregion
		#region Decorator mapping
		/// <summary>
		/// Initialize shape decorator mappings.  This is done here rather than in individual shapes because decorator maps
		/// are defined per diagram type rather than per shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
			global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase.DecoratorsInitialized += MetaforaClaseDecoratorMap.OnDecoratorsInitialized;
		}
		
		/// <summary>
		/// Class containing decorator path traversal methods for MetaforaClase.
		/// </summary>
		internal static partial class MetaforaClaseDecoratorMap
		{
			/// <summary>
			/// Event handler called when decorator initialization is complete for MetaforaClase.  Adds decorator mappings for this shape or connector.
			/// </summary>
			public static void OnDecoratorsInitialized(object sender, global::System.EventArgs e)
			{
				DslDiagrams::ShapeElement shape = (DslDiagrams::ShapeElement)sender;
				DslDiagrams::AssociatedPropertyInfo propertyInfo;
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::UPM_IPS.PLFLARCCAYRClassWeb.Clase.nombreDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "nombreClaseDec").AssociateValueWith(shape.Store, propertyInfo);
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::UPM_IPS.PLFLARCCAYRClassWeb.Clase.idDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "idDec").AssociateValueWith(shape.Store, propertyInfo);
			}
		}
		
		#endregion
		
		/// <summary>
		/// Dispose of connect actions.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			try
			{
				if(disposing)
				{
					this.UnsubscribeCompartmentItemsEvents();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		#region Constructors, domain class Id
	
		/// <summary>
		/// PLFLARCCAYRClassWebDiagram domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x4861cff9, 0xa103, 0x4745, 0xa9, 0xdd, 0x72, 0xe3, 0x09, 0xbf, 0x73, 0x24);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public PLFLARCCAYRClassWebDiagram(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public PLFLARCCAYRClassWebDiagram(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.PLFLARCCAYRClassWeb
{
	
		/// <summary>
		/// Double derived implementation for the rule that initiates view fixup when an element that has an associated shape is added to the model.
		/// This now enables the DSL author to everride the SkipFixUp() method 
		/// </summary>
		internal partial class FixUpDiagramBase : DslModeling::AddRule
		{
			protected virtual bool SkipFixup(DslModeling::ModelElement childElement)
			{
				return childElement.IsDeleted;
			}
		}
	
		/// <summary>
		/// Rule that initiates view fixup when an element that has an associated shape is added to the model. 
		/// </summary>
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.Clase), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		internal sealed partial class FixUpDiagram : FixUpDiagramBase
		{
			[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
			public override void ElementAdded(DslModeling::ElementAddedEventArgs e)
			{
				if(e == null) throw new global::System.ArgumentNullException("e");
			
				DslModeling::ModelElement childElement = e.ModelElement;
				if (this.SkipFixup(childElement))
					return;
				DslModeling::ModelElement parentElement;
				if(childElement is global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion)
				{
					parentElement = GetParentForOperacion((global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion)childElement);
				} else
				if(childElement is global::UPM_IPS.PLFLARCCAYRClassWeb.Clase)
				{
					parentElement = GetParentForClase((global::UPM_IPS.PLFLARCCAYRClassWeb.Clase)childElement);
				} else
				{
					parentElement = null;
				}
				
				if(parentElement != null)
				{
					DslDiagrams::Diagram.FixUpDiagram(parentElement, childElement);
				}
			}
			public static global::UPM_IPS.PLFLARCCAYRClassWeb.Tapiz GetParentForClase( global::UPM_IPS.PLFLARCCAYRClassWeb.Clase root )
			{
				// Segments 0 and 1
				global::UPM_IPS.PLFLARCCAYRClassWeb.Tapiz result = root.Tapiz;
				if ( result == null ) return null;
				return result;
			}
			public static global::UPM_IPS.PLFLARCCAYRClassWeb.Tapiz GetParentForOperacion( global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion root )
			{
				// Segments 0 and 1
				global::UPM_IPS.PLFLARCCAYRClassWeb.Clase root2 = root.Clase;
				if ( root2 == null ) return null;
				// Segments 2 and 3
				global::UPM_IPS.PLFLARCCAYRClassWeb.Tapiz result = root2.Tapiz;
				if ( result == null ) return null;
				return result;
			}
		}
		
		/// <summary>
		/// Rule to update compartments when an item is added to the list
		/// </summary>
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemAddRule : DslModeling::AddRule
		{
			/// <summary>
			/// Called when an element is added. 
			/// </summary>
			/// <param name="e"></param>
			public override void ElementAdded(DslModeling::ElementAddedEventArgs e)
			{
				ElementAdded(e, false);
			}
	
			internal static void ElementAdded(DslModeling::ElementAddedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if (e.ModelElement.IsDeleted)
					return;
				if(e.ModelElement is global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo)
				{
					global::System.Collections.IEnumerable elements = GetClaseForMetaforaClaseAtrCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo)e.ModelElement);
					UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase), "AtrCompartment", repaintOnly);
				}
				if(e.ModelElement is global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro)
				{
					global::System.Collections.IEnumerable elements = GetOperacionForMetaforaOperacionParamCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro)e.ModelElement);
					UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion), "ParamCompartment", repaintOnly);
				}
			}
			
			#region static DomainPath traversal methods to get the list of compartments to update
			internal static global::System.Collections.ICollection GetClaseForMetaforaClaseAtrCompartmentFromLastLink(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo root)
			{
				// Segment 0
				global::UPM_IPS.PLFLARCCAYRClassWeb.Clase result = root.Clase;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			internal static global::System.Collections.ICollection GetClaseForMetaforaClaseAtrCompartment(global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo root)
			{
				// Segments 1 and 0
				global::UPM_IPS.PLFLARCCAYRClassWeb.Clase result = root.Clase;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			internal static global::System.Collections.ICollection GetOperacionForMetaforaOperacionParamCompartmentFromLastLink(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro root)
			{
				// Segment 0
				global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion result = root.Operacion;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			internal static global::System.Collections.ICollection GetOperacionForMetaforaOperacionParamCompartment(global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros root)
			{
				// Segments 1 and 0
				global::UPM_IPS.PLFLARCCAYRClassWeb.Operacion result = root.Operacion;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			#endregion
	
			#region helper method to update compartments 
			/// <summary>
			/// Updates the compartments for the shapes associated to the given list of model elements
			/// </summary>
			/// <param name="elements">List of model elements</param>
			/// <param name="shapeType">The type of shape that needs updating</param>
			/// <param name="compartmentName">The name of the compartment to update</param>
			/// <param name="repaintOnly">If true, the method will only invalidate the shape for a repaint, without re-initializing the shape.</param>
			internal static void UpdateCompartments(global::System.Collections.IEnumerable elements, global::System.Type shapeType, string compartmentName, bool repaintOnly)
			{
				foreach (DslModeling::ModelElement element in elements)
				{
					DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> pels = DslDiagrams::PresentationViewsSubject.GetPresentation(element);
					foreach (DslDiagrams::PresentationElement pel in pels)
					{
						DslDiagrams::CompartmentShape compartmentShape = pel as DslDiagrams::CompartmentShape;
						if (compartmentShape != null && shapeType.IsAssignableFrom(compartmentShape.GetType()))
						{
							if (repaintOnly)
							{
								compartmentShape.Invalidate();
							}
							else
							{
								foreach(DslDiagrams::CompartmentMapping mapping in compartmentShape.GetCompartmentMappings())
								{
									if(mapping.CompartmentId==compartmentName)
									{
										mapping.InitializeCompartmentShape(compartmentShape);
										break;
									}
								}
							}
						}
					}
				}
			}
			#endregion
		}
		
		/// <summary>
		/// Rule to update compartments when an items is removed from the list
		/// </summary>
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemDeleteRule : DslModeling::DeleteRule
		{
			/// <summary>
			/// Called when an element is deleted
			/// </summary>
			/// <param name="e"></param>
			public override void ElementDeleted(DslModeling::ElementDeletedEventArgs e)
			{
				ElementDeleted(e, false);
			}
			
			internal static void ElementDeleted(DslModeling::ElementDeletedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(e.ModelElement is global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo)
				{
					global::System.Collections.ICollection elements = CompartmentItemAddRule.GetClaseForMetaforaClaseAtrCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase), "AtrCompartment", repaintOnly);
				}
				if(e.ModelElement is global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro)
				{
					global::System.Collections.ICollection elements = CompartmentItemAddRule.GetOperacionForMetaforaOperacionParamCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion), "ParamCompartment", repaintOnly);
				}
			}
		}
		
		/// <summary>
		/// Rule to update compartments when the property on an item being displayed changes.
		/// </summary>
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemChangeRule : DslModeling::ChangeRule 
		{
			/// <summary>
			/// Called when an element is changed
			/// </summary>
			/// <param name="e"></param>
			public override void ElementPropertyChanged(DslModeling::ElementPropertyChangedEventArgs e)
			{
				ElementPropertyChanged(e, false);
			}
			
			internal static void ElementPropertyChanged(DslModeling::ElementPropertyChangedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(e.ModelElement is global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo && e.DomainProperty.Id == global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo.nombreTipoCalculadaDomainPropertyId)
				{
					global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetClaseForMetaforaClaseAtrCompartment((global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase), "AtrCompartment", repaintOnly);
				}
				if(e.ModelElement is global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros && e.DomainProperty.Id == global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros.nombreTipoCalculadaDomainPropertyId)
				{
					global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetOperacionForMetaforaOperacionParamCompartment((global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion), "ParamCompartment", repaintOnly);
				}
			}
		}
		
		/// <summary>
		/// Rule to update compartments when a roleplayer change happens
		/// </summary>
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemRolePlayerChangeRule : DslModeling::RolePlayerChangeRule 
		{
			/// <summary>
			/// Called when the roleplayer on a link changes.
			/// </summary>
			/// <param name="e"></param>
			public override void RolePlayerChanged(DslModeling::RolePlayerChangedEventArgs e)
			{
				RolePlayerChanged(e, false);
			}
			
			internal static void RolePlayerChanged(DslModeling::RolePlayerChangedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(e.DomainRole.IsSource)
					{
						//global::System.Collections.IEnumerable oldElements = CompartmentItemAddRule.GetClaseForMetaforaClaseAtrCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo)e.OldRolePlayer);
						//foreach(DslModeling::ModelElement element in oldElements)
						//{
						//	DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> pels = DslDiagrams::PresentationViewsSubject.GetPresentation(element);
						//	foreach(DslDiagrams::PresentationElement pel in pels)
						//	{
						//		global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase compartmentShape = pel as global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase;
						//		if(compartmentShape != null)
						//		{
						//			compartmentShape.GetCompartmentMappings()[0].InitializeCompartmentShape(compartmentShape);
						//		}
						//	}
						//}
						
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetClaseForMetaforaClaseAtrCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo)e.ElementLink);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase), "AtrCompartment", repaintOnly);
					}
					else 
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetClaseForMetaforaClaseAtrCompartment((global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo)e.NewRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase), "AtrCompartment", repaintOnly);
					}
				}
				if(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(e.DomainRole.IsSource)
					{
						//global::System.Collections.IEnumerable oldElements = CompartmentItemAddRule.GetOperacionForMetaforaOperacionParamCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros)e.OldRolePlayer);
						//foreach(DslModeling::ModelElement element in oldElements)
						//{
						//	DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> pels = DslDiagrams::PresentationViewsSubject.GetPresentation(element);
						//	foreach(DslDiagrams::PresentationElement pel in pels)
						//	{
						//		global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion compartmentShape = pel as global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion;
						//		if(compartmentShape != null)
						//		{
						//			compartmentShape.GetCompartmentMappings()[0].InitializeCompartmentShape(compartmentShape);
						//		}
						//	}
						//}
						
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetOperacionForMetaforaOperacionParamCompartmentFromLastLink((global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro)e.ElementLink);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion), "ParamCompartment", repaintOnly);
					}
					else 
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetOperacionForMetaforaOperacionParamCompartment((global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros)e.NewRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion), "ParamCompartment", repaintOnly);
					}
				}
			}
		}
	
		/// <summary>
		/// Rule to update compartments when the order of items in the list changes.
		/// </summary>
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemRolePlayerPositionChangeRule : DslModeling::RolePlayerPositionChangeRule 
		{
			/// <summary>
			/// Called when the order of a roleplayer in a relationship changes
			/// </summary>
			/// <param name="e"></param>
			public override void RolePlayerPositionChanged(DslModeling::RolePlayerOrderChangedEventArgs e)
			{
				RolePlayerPositionChanged(e, false);
			}
			
			internal static void RolePlayerPositionChanged(DslModeling::RolePlayerOrderChangedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.ClaseHasAtributo).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(!e.CounterpartDomainRole.IsSource)
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetClaseForMetaforaClaseAtrCompartment((global::UPM_IPS.PLFLARCCAYRClassWeb.Atributo)e.CounterpartRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaClase), "AtrCompartment", repaintOnly);
					}
				}
				if(typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.OperacionHasParametro).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(!e.CounterpartDomainRole.IsSource)
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetOperacionForMetaforaOperacionParamCompartment((global::UPM_IPS.PLFLARCCAYRClassWeb.Parametros)e.CounterpartRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::UPM_IPS.PLFLARCCAYRClassWeb.MetaforaOperacion), "ParamCompartment", repaintOnly);
					}
				}
			}
		}
	
	}