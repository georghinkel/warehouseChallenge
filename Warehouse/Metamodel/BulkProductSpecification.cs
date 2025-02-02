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
    /// The default implementation of the BulkProductSpecification class
    /// </summary>
    [XmlNamespaceAttribute("https://multi-workshop.github.io/warehouse/nmeta")]
    [XmlNamespacePrefixAttribute("warehouse")]
    [ModelRepresentationClassAttribute("https://multi-workshop.github.io/warehouse/nmeta#//BulkProductSpecification")]
    [DebuggerDisplayAttribute("BulkProductSpecification {Name}")]
    public partial class BulkProductSpecification : NMF.Models.Meta.ReferenceType, IBulkProductSpecification, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the TaxRate property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private double _taxRate;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _taxRateAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveTaxRateAttribute);
        
        /// <summary>
        /// The backing field for the Currency property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private string _currency;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _currencyAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveCurrencyAttribute);
        
        /// <summary>
        /// The backing field for the IntroductionDate property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private DateTime _introductionDate;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _introductionDateAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveIntroductionDateAttribute);
        
        /// <summary>
        /// The backing field for the IsAbstract property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private bool _isAbstract = false;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _isAbstractAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveIsAbstractAttribute);
        
        /// <summary>
        /// The backing field for the IdentifierScope property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private NMF.Models.Meta.IdentifierScope _identifierScope;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _identifierScopeAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveIdentifierScopeAttribute);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _identifierReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveIdentifierReference);
        
        /// <summary>
        /// The backing field for the Identifier property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private NMF.Models.Meta.IAttribute _identifier;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        event EventHandler<ValueChangedEventArgs> IClass.InstanceOfChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.InstanceOfChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IClass> IClass.BaseTypes
        {
            get
            {
                return new BulkProductSpecificationBaseTypesCollection(this);
            }
        }
        
        /// <summary>
        /// The taxRate property
        /// </summary>
        [DisplayNameAttribute("taxRate")]
        [CategoryAttribute("ProductSpecification")]
        [XmlElementNameAttribute("taxRate")]
        [XmlAttributeAttribute(true)]
        public double TaxRate
        {
            get
            {
                return this._taxRate;
            }
            set
            {
                if ((this._taxRate != value))
                {
                    double old = this._taxRate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTaxRateChanging(e);
                    this.OnPropertyChanging("TaxRate", e, _taxRateAttribute);
                    this._taxRate = value;
                    this.OnTaxRateChanged(e);
                    this.OnPropertyChanged("TaxRate", e, _taxRateAttribute);
                }
            }
        }
        
        /// <summary>
        /// The currency property
        /// </summary>
        [DisplayNameAttribute("currency")]
        [CategoryAttribute("ProductSpecification")]
        [XmlElementNameAttribute("currency")]
        [XmlAttributeAttribute(true)]
        public string Currency
        {
            get
            {
                return this._currency;
            }
            set
            {
                if ((this._currency != value))
                {
                    string old = this._currency;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCurrencyChanging(e);
                    this.OnPropertyChanging("Currency", e, _currencyAttribute);
                    this._currency = value;
                    this.OnCurrencyChanged(e);
                    this.OnPropertyChanged("Currency", e, _currencyAttribute);
                }
            }
        }
        
        /// <summary>
        /// The introductionDate property
        /// </summary>
        [TypeConverterAttribute(typeof(IsoDateTimeConverter))]
        [DisplayNameAttribute("introductionDate")]
        [CategoryAttribute("ProductSpecification")]
        [XmlElementNameAttribute("introductionDate")]
        [XmlAttributeAttribute(true)]
        public DateTime IntroductionDate
        {
            get
            {
                return this._introductionDate;
            }
            set
            {
                if ((this._introductionDate != value))
                {
                    DateTime old = this._introductionDate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIntroductionDateChanging(e);
                    this.OnPropertyChanging("IntroductionDate", e, _introductionDateAttribute);
                    this._introductionDate = value;
                    this.OnIntroductionDateChanged(e);
                    this.OnPropertyChanged("IntroductionDate", e, _introductionDateAttribute);
                }
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IReferenceConstraint> IClass.ReferenceConstraints
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IReferenceConstraint>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IAttributeConstraint> IClass.AttributeConstraints
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IAttributeConstraint>.Instance;
            }
        }
        
        NMF.Models.Meta.IClass IClass.InstanceOf
        {
            get
            {
                return null;
            }
            set
            {
                if ((value != null))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        /// <summary>
        /// The IsAbstract property
        /// </summary>
        [DefaultValueAttribute(false)]
        [TypeConverterAttribute(typeof(LowercaseBooleanConverter))]
        [CategoryAttribute("Class")]
        [XmlAttributeAttribute(true)]
        public bool IsAbstract
        {
            get
            {
                return this._isAbstract;
            }
            set
            {
                if ((this._isAbstract != value))
                {
                    bool old = this._isAbstract;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIsAbstractChanging(e);
                    this.OnPropertyChanging("IsAbstract", e, _isAbstractAttribute);
                    this._isAbstract = value;
                    this.OnIsAbstractChanged(e);
                    this.OnPropertyChanged("IsAbstract", e, _isAbstractAttribute);
                }
            }
        }
        
        /// <summary>
        /// Specifies whether the identifier is valid only in the scope of its container or on a global scope.
        /// </summary>
        /// <remarks>This attribute is ignored when this class is not identified.</remarks>
        [DescriptionAttribute("Specifies whether the identifier is valid only in the scope of its container or o" +
            "n a global scope.")]
        [CategoryAttribute("Class")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.Meta.IdentifierScope IdentifierScope
        {
            get
            {
                return this._identifierScope;
            }
            set
            {
                if ((this._identifierScope != value))
                {
                    NMF.Models.Meta.IdentifierScope old = this._identifierScope;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIdentifierScopeChanging(e);
                    this.OnPropertyChanging("IdentifierScope", e, _identifierScopeAttribute);
                    this._identifierScope = value;
                    this.OnIdentifierScopeChanged(e);
                    this.OnPropertyChanged("IdentifierScope", e, _identifierScopeAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the attribute that will identify instances of this class
        /// </summary>
        [DescriptionAttribute("Gets or sets the attribute that will identify instances of this class")]
        [CategoryAttribute("Class")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.Meta.IAttribute Identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                if ((this._identifier != value))
                {
                    NMF.Models.Meta.IAttribute old = this._identifier;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIdentifierChanging(e);
                    this.OnPropertyChanging("Identifier", e, _identifierReference);
                    this._identifier = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetIdentifier;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetIdentifier;
                    }
                    this.OnIdentifierChanged(e);
                    this.OnPropertyChanged("Identifier", e, _identifierReference);
                }
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://multi-workshop.github.io/warehouse/nmeta#//BulkProductSpecification")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired when the TaxRate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TaxRateChanged;
        
        /// <summary>
        /// Gets fired before the TaxRate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TaxRateChanging;
        
        /// <summary>
        /// Gets fired when the Currency property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CurrencyChanged;
        
        /// <summary>
        /// Gets fired before the Currency property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> CurrencyChanging;
        
        /// <summary>
        /// Gets fired when the IntroductionDate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IntroductionDateChanged;
        
        /// <summary>
        /// Gets fired before the IntroductionDate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IntroductionDateChanging;
        
        /// <summary>
        /// Gets fired when the IsAbstract property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsAbstractChanged;
        
        /// <summary>
        /// Gets fired before the IsAbstract property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IsAbstractChanging;
        
        /// <summary>
        /// Gets fired when the IdentifierScope property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdentifierScopeChanged;
        
        /// <summary>
        /// Gets fired before the IdentifierScope property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdentifierScopeChanging;
        
        /// <summary>
        /// Gets fired before the Identifier property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdentifierChanging;
        
        /// <summary>
        /// Gets fired when the Identifier property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdentifierChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveTaxRateAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(Hsrm.DeepModeling.Warehouse.Warehouse.ProductSpecification.ClassInstance)).Resolve("taxRate")));
        }
        
        /// <summary>
        /// Raises the TaxRateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTaxRateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TaxRateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TaxRateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTaxRateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TaxRateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveCurrencyAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(Hsrm.DeepModeling.Warehouse.Warehouse.ProductSpecification.ClassInstance)).Resolve("currency")));
        }
        
        /// <summary>
        /// Raises the CurrencyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCurrencyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CurrencyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CurrencyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCurrencyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.CurrencyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveIntroductionDateAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(Hsrm.DeepModeling.Warehouse.Warehouse.ProductSpecification.ClassInstance)).Resolve("introductionDate")));
        }
        
        /// <summary>
        /// Raises the IntroductionDateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIntroductionDateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IntroductionDateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IntroductionDateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIntroductionDateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IntroductionDateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveIsAbstractAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.Meta.Class.ClassInstance)).Resolve("IsAbstract")));
        }
        
        /// <summary>
        /// Raises the IsAbstractChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsAbstractChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsAbstractChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IsAbstractChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIsAbstractChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IsAbstractChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveIdentifierScopeAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.Meta.Class.ClassInstance)).Resolve("IdentifierScope")));
        }
        
        /// <summary>
        /// Raises the IdentifierScopeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdentifierScopeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdentifierScopeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IdentifierScopeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdentifierScopeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdentifierScopeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveIdentifierReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.Meta.Class.ClassInstance)).Resolve("Identifier")));
        }
        
        /// <summary>
        /// Raises the IdentifierChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdentifierChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdentifierChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IdentifierChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdentifierChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdentifierChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Identifier property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetIdentifier(object sender, System.EventArgs eventArgs)
        {
            this.Identifier = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "IDENTIFIER"))
            {
                return this.Identifier;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TAXRATE"))
            {
                return this.TaxRate;
            }
            if ((attribute == "CURRENCY"))
            {
                return this.Currency;
            }
            if ((attribute == "INTRODUCTIONDATE"))
            {
                return this.IntroductionDate;
            }
            if ((attribute == "ISABSTRACT"))
            {
                return this.IsAbstract;
            }
            if ((attribute == "IDENTIFIERSCOPE"))
            {
                return this.IdentifierScope;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "IDENTIFIER"))
            {
                this.Identifier = ((NMF.Models.Meta.IAttribute)(value));
                return;
            }
            if ((feature == "TAXRATE"))
            {
                this.TaxRate = ((double)(value));
                return;
            }
            if ((feature == "CURRENCY"))
            {
                this.Currency = ((string)(value));
                return;
            }
            if ((feature == "INTRODUCTIONDATE"))
            {
                this.IntroductionDate = ((System.DateTime)(value));
                return;
            }
            if ((feature == "ISABSTRACT"))
            {
                this.IsAbstract = ((bool)(value));
                return;
            }
            if ((feature == "IDENTIFIERSCOPE"))
            {
                this.IdentifierScope = ((NMF.Models.Meta.IdentifierScope)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "TAXRATE"))
            {
                return Observable.Box(new TaxRateProxy(this));
            }
            if ((attribute == "CURRENCY"))
            {
                return new CurrencyProxy(this);
            }
            if ((attribute == "INTRODUCTIONDATE"))
            {
                return Observable.Box(new IntroductionDateProxy(this));
            }
            if ((attribute == "ISABSTRACT"))
            {
                return Observable.Box(new IsAbstractProxy(this));
            }
            if ((attribute == "IDENTIFIERSCOPE"))
            {
                return Observable.Box(new IdentifierScopeProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "IDENTIFIER"))
            {
                return new IdentifierProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://multi-workshop.github.io/warehouse/nmeta#//BulkProductSpecification")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the taxRate property
        /// </summary>
        private sealed class TaxRateProxy : ModelPropertyChange<IProductSpecification, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TaxRateProxy(IProductSpecification modelElement) : 
                    base(modelElement, "taxRate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override double Value
            {
                get
                {
                    return this.ModelElement.TaxRate;
                }
                set
                {
                    this.ModelElement.TaxRate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the currency property
        /// </summary>
        private sealed class CurrencyProxy : ModelPropertyChange<IProductSpecification, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CurrencyProxy(IProductSpecification modelElement) : 
                    base(modelElement, "currency")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Currency;
                }
                set
                {
                    this.ModelElement.Currency = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the introductionDate property
        /// </summary>
        private sealed class IntroductionDateProxy : ModelPropertyChange<IProductSpecification, System.DateTime>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IntroductionDateProxy(IProductSpecification modelElement) : 
                    base(modelElement, "introductionDate")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override System.DateTime Value
            {
                get
                {
                    return this.ModelElement.IntroductionDate;
                }
                set
                {
                    this.ModelElement.IntroductionDate = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsAbstract property
        /// </summary>
        private sealed class IsAbstractProxy : ModelPropertyChange<NMF.Models.Meta.IClass, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsAbstractProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "IsAbstract")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsAbstract;
                }
                set
                {
                    this.ModelElement.IsAbstract = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IdentifierScope property
        /// </summary>
        private sealed class IdentifierScopeProxy : ModelPropertyChange<NMF.Models.Meta.IClass, NMF.Models.Meta.IdentifierScope>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdentifierScopeProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "IdentifierScope")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IdentifierScope Value
            {
                get
                {
                    return this.ModelElement.IdentifierScope;
                }
                set
                {
                    this.ModelElement.IdentifierScope = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the InstanceOf property
        /// </summary>
        private sealed class InstanceOfProxy : ModelPropertyChange<NMF.Models.Meta.IClass, NMF.Models.Meta.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InstanceOfProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "InstanceOf")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IClass Value
            {
                get
                {
                    return this.ModelElement.InstanceOf;
                }
                set
                {
                    this.ModelElement.InstanceOf = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Identifier property
        /// </summary>
        private sealed class IdentifierProxy : ModelPropertyChange<NMF.Models.Meta.IClass, NMF.Models.Meta.IAttribute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdentifierProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "Identifier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IAttribute Value
            {
                get
                {
                    return this.ModelElement.Identifier;
                }
                set
                {
                    this.ModelElement.Identifier = value;
                }
            }
        }
    }
}
