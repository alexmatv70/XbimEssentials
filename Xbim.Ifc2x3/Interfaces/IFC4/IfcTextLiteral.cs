// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class @IfcTextLiteral : IIfcTextLiteral
	{
		Ifc4.PresentationAppearanceResource.IfcPresentableText IIfcTextLiteral.Literal 
		{ 
			get
			{
				return new Ifc4.PresentationAppearanceResource.IfcPresentableText(Literal);
			} 
		}
		IIfcAxis2Placement IIfcTextLiteral.Placement 
		{ 
			get
			{
				if (Placement == null) return null;
				var ifcaxis2placement2d = Placement as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
					return ifcaxis2placement2d;
				var ifcaxis2placement3d = Placement as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
					return ifcaxis2placement3d;
				return null;
			} 
		}
		Ifc4.PresentationDefinitionResource.IfcTextPath IIfcTextLiteral.Path 
		{ 
			get
			{
				switch (Path)
				{
					case IfcTextPath.LEFT:
						return Ifc4.PresentationDefinitionResource.IfcTextPath.LEFT;
					
					case IfcTextPath.RIGHT:
						return Ifc4.PresentationDefinitionResource.IfcTextPath.RIGHT;
					
					case IfcTextPath.UP:
						return Ifc4.PresentationDefinitionResource.IfcTextPath.UP;
					
					case IfcTextPath.DOWN:
						return Ifc4.PresentationDefinitionResource.IfcTextPath.DOWN;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}