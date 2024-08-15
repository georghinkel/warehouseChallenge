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
    /// The public interface for Return
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Return))]
    [XmlDefaultImplementationTypeAttribute(typeof(Return))]
    [ModelRepresentationClassAttribute("https://multi-workshop.github.io/warehouse/nmeta#//Return")]
    public interface IReturn : NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The returnDate property
        /// </summary>
        [TypeConverterAttribute(typeof(IsoDateTimeConverter))]
        [DisplayNameAttribute("returnDate")]
        [CategoryAttribute("Return")]
        [XmlElementNameAttribute("returnDate")]
        [XmlAttributeAttribute(true)]
        DateTime ReturnDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The reason property
        /// </summary>
        [DisplayNameAttribute("reason")]
        [CategoryAttribute("Return")]
        [XmlElementNameAttribute("reason")]
        [XmlAttributeAttribute(true)]
        string Reason
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the ReturnDate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnDateChanged;
        
        /// <summary>
        /// Gets fired before the ReturnDate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnDateChanging;
        
        /// <summary>
        /// Gets fired when the Reason property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanged;
        
        /// <summary>
        /// Gets fired before the Reason property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReasonChanging;
    }
}
