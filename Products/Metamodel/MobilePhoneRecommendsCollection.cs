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
    /// The collection class to implement the refined recommends reference for the MobilePhone class
    /// </summary>
    public class MobilePhoneRecommendsCollection : ICollectionExpression<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct>, ICollection<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct>
    {
        
        private IMobilePhone _parent;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public MobilePhoneRecommendsCollection(IMobilePhone parent)
        {
            this._parent = parent;
            parent.RecommendedCaseChanged += this.HandleValueChange;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 0;
                if ((this._parent.RecommendedCase != null))
                {
                    count = (count + 1);
                }
                return count;
            }
        }
        
        /// <summary>
        /// Gets a value indicating that the collection is not read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        
        /// <summary>
        /// Returns that this composed collection is always attached.
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired when the contents of this collection changes
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        
        /// <summary>
        /// Fires the CollectionChanged event
        /// </summary>
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private void HandleValueChange(object sender, NMF.Expressions.ValueChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventArgs collectionEvent = null;
            if ((eventArgs.NewValue != null))
            {
                if ((eventArgs.OldValue != null))
                {
                    collectionEvent = new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Replace, eventArgs.NewValue, eventArgs.OldValue);
                }
                else
                {
                    collectionEvent = new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Add, eventArgs.NewValue);
                }
            }
            else
            {
                collectionEvent = new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Remove, eventArgs.OldValue);
            }
            this.OnCollectionChanged(collectionEvent);
        }
        
        /// <summary>
        /// Adds the given element to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public virtual void Add(Hsrm.DeepModeling.Warehouse.Warehouse.IProduct item)
        {
            if ((this._parent.RecommendedCase == null))
            {
                IMobilePhoneCase recommendedCaseCasted = item.As<IMobilePhoneCase>();
                if ((recommendedCaseCasted != null))
                {
                    this._parent.RecommendedCase = recommendedCaseCasted;
                    return;
                }
            }
        }
        
        /// <summary>
        /// Clears the collection and resets all references that implement it.
        /// </summary>
        public virtual void Clear()
        {
            this._parent.RecommendedCase = null;
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(Hsrm.DeepModeling.Warehouse.Warehouse.IProduct item)
        {
            if ((item == this._parent.RecommendedCase))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Copies the contents of the collection to the given array starting from the given array index
        /// </summary>
        /// <param name="array">The array in which the elements should be copied</param>
        /// <param name="arrayIndex">The starting index</param>
        public virtual void CopyTo(Hsrm.DeepModeling.Warehouse.Warehouse.IProduct[] array, int arrayIndex)
        {
            if ((this._parent.RecommendedCase != null))
            {
                array[arrayIndex] = this._parent.RecommendedCase;
                arrayIndex = (arrayIndex + 1);
            }
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(Hsrm.DeepModeling.Warehouse.Warehouse.IProduct item)
        {
            if ((this._parent.RecommendedCase == item))
            {
                this._parent.RecommendedCase = null;
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct> GetEnumerator()
        {
            return Enumerable.Empty<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct>().Concat(this._parent.RecommendedCase).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        public virtual INotifyCollection<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct> AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct> IEnumerableExpression<Hsrm.DeepModeling.Warehouse.Warehouse.IProduct>.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Attaches this collection class
        /// </summary>
        public void Attach()
        {
        }
        
        /// <summary>
        /// Detaches this collection class
        /// </summary>
        public void Detach()
        {
        }
    }
}
