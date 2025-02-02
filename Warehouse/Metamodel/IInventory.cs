//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hsrm.DeepModeling.Warehouse.Warehouse
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
    using System.Collections.Specialized;
    using NMF.Models.Repository;
    
    
    /// <summary>
    /// The public interface for Inventory
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Inventory))]
    [XmlDefaultImplementationTypeAttribute(typeof(Inventory))]
    [ModelRepresentationClassAttribute("https://multi-workshop.github.io/warehouse/nmeta#//Inventory")]
    public interface IInventory : NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The bulkProducts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("bulkProducts")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        ICollectionExpression<IBulkProduct> BulkProducts
        {
            get;
        }
        
        /// <summary>
        /// The items property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("items")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        ICollectionExpression<ISaleItem> Items
        {
            get;
        }
    }
}
