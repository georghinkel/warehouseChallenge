//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hsrm.DeepModeling.Warehouse.Products.MyWarehouse
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
    using System.Collections.Specialized;
    
    
    /// <summary>
    /// The default implementation of the AABatteryCell class
    /// </summary>
    [XmlNamespaceAttribute("https://example.org")]
    [XmlNamespacePrefixAttribute("ex")]
    [ModelRepresentationClassAttribute("https://example.org/#//AABatteryCell")]
    [DebuggerDisplayAttribute("AABatteryCell {Name}")]
    public partial class AABatteryCell : Hsrm.DeepModeling.Warehouse.Warehouse.BulkProduct, IAABatteryCell, NMF.Models.IModelElement
    {
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new AABatteryCellChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the ProductSpecification model for this type
        /// </summary>
        public new static Hsrm.DeepModeling.Warehouse.Warehouse.IProductSpecification ProductSpecificationInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/#//AABatteryCell")));
                }
                return ((Hsrm.DeepModeling.Warehouse.Warehouse.IProductSpecification)(_classInstance));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/#//AABatteryCell")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the ProductSpecification for this model element
        /// </summary>
        public override Hsrm.DeepModeling.Warehouse.Warehouse.IProductSpecification GetProductSpecification()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/#//AABatteryCell")));
            }
            return ((Hsrm.DeepModeling.Warehouse.Warehouse.IProductSpecification)(_classInstance));
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://example.org/#//AABatteryCell")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AABatteryCell class
        /// </summary>
        public class AABatteryCellChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private AABatteryCell _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AABatteryCellChildrenCollection(AABatteryCell parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    return count;
                }
            }
            
            /// <summary>
            /// Registers event hooks to keep the collection up to date
            /// </summary>
            protected override void AttachCore()
            {
            }
            
            /// <summary>
            /// Unregisters all event hooks registered by AttachCore
            /// </summary>
            protected override void DetachCore()
            {
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().GetEnumerator();
            }
        }
    }
}
