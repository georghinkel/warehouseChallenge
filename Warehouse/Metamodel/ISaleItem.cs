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
    /// The public interface for SaleItem
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SaleItem))]
    [XmlDefaultImplementationTypeAttribute(typeof(SaleItem))]
    [ModelRepresentationClassAttribute("https://multi-workshop.github.io/warehouse/nmeta#//SaleItem")]
    public interface ISaleItem : NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The return property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("return")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IReturn Return
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sale property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("sale")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        ISalePrice Sale
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Return property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnChanging;
        
        /// <summary>
        /// Gets fired when the Return property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnChanged;
        
        /// <summary>
        /// Gets fired before the Sale property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SaleChanging;
        
        /// <summary>
        /// Gets fired when the Sale property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> SaleChanged;
        
        /// <summary>
        /// Gets the IndividualProduct for this model element
        /// </summary>
        IIndividualProduct GetIndividualProduct();
    }
}
