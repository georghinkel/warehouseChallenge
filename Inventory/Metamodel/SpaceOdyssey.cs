//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hsrm.DeepModeling.Warehouse.Products.Products
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using NMF.Expressions;
    using NMF.Expressions.Linq;
    using NMF.Models;
    using NMF.Models.Meta;
    using NMF.Models.Collections;
    using NMF.Models.Expressions;
    using NMF.Collections.Generic;
    using NMF.Collections.ObjectModel;
    using NMF.Serialization;
    using NMF.Utilities;
    using NMF.Models.Repository;
    using Hsrm.DeepModeling.Warehouse.Warehouse;
    
    
    /// <summary>
    /// The default implementation of the SpaceOdyssey class
    /// </summary>
    [XmlNamespaceAttribute("https://example.org/products")]
    [XmlNamespacePrefixAttribute("p")]
    [ModelRepresentationClassAttribute("https://example.org/products#//SpaceOdyssey")]
    public partial class SpaceOdyssey : Hsrm.DeepModeling.Warehouse.Warehouse.SaleItem, ISpaceOdyssey, NMF.Models.IModelElement
    {
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Gets the IndividualProduct model for this type
        /// </summary>
        public new static Hsrm.DeepModeling.Warehouse.Warehouse.IIndividualProduct IndividualProductInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/products#//SpaceOdyssey")));
                }
                return ((Hsrm.DeepModeling.Warehouse.Warehouse.IIndividualProduct)(_classInstance));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/products#//SpaceOdyssey")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the IndividualProduct for this model element
        /// </summary>
        public override Hsrm.DeepModeling.Warehouse.Warehouse.IIndividualProduct GetIndividualProduct()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/products#//SpaceOdyssey")));
            }
            return ((Hsrm.DeepModeling.Warehouse.Warehouse.IIndividualProduct)(_classInstance));
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/products#//SpaceOdyssey")));
            }
            return _classInstance;
        }
    }
}
