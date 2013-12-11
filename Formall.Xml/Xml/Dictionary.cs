﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Formall.Xml
{
    internal class Dictionary : Entry, IDictionary
    {
        public static implicit operator XElement(Dictionary dictionary)
        {
            return dictionary != null ? dictionary._element : null;
        }

        private readonly XElement _element;
        private readonly Model _model;

        public Dictionary(XElement element, Model model)
        {
            _element = element;
            _model = model;
        }

        public Dictionary(XElement element, Model model, IDictionary dictionary)
            : this(element, model)
        {
            // deep copy document in _document
        }

        public Dictionary(XElement element, IDictionary dictionary)
            : this(element, dictionary.Model, dictionary)
        {
        }

        public override DataType Type
        {
            get { return _model; }
        }

        #region - ICollection -

        void ICollection<KeyValuePair<string, IEntry>>.Add(KeyValuePair<string, IEntry> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<string, IEntry>>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<string, IEntry>>.Contains(KeyValuePair<string, IEntry> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<string, IEntry>>.CopyTo(KeyValuePair<string, IEntry>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<KeyValuePair<string, IEntry>>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<string, IEntry>>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<string, IEntry>>.Remove(KeyValuePair<string, IEntry> item)
        {
            throw new NotImplementedException();
        }

        #endregion - ICollection -

        #region - IDictionary -

        public Model Model
        {
            get { return _model; }
        }

        void IDictionary<string, IEntry>.Add(string key, IEntry value)
        {
        }

        bool IDictionary<string, IEntry>.ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        ICollection<string> IDictionary<string, IEntry>.Keys
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary<string, IEntry>.Remove(string key)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<string, IEntry>.TryGetValue(string key, out IEntry value)
        {
            throw new NotImplementedException();
        }

        ICollection<IEntry> IDictionary<string, IEntry>.Values
        {
            get { throw new NotImplementedException(); }
        }

        IEntry IDictionary<string, IEntry>.this[string key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion - IDictionary -

        #region - IEntry -

        #endregion - IEntry -

        #region - IEnumerable -

        IEnumerator<KeyValuePair<string, IEntry>> IEnumerable<KeyValuePair<string, IEntry>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion - IEnumerable -

        #region - IValidatable -

        IEnumerable<ValidationResult> IValidatable.Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

        #endregion - IValidatable -
    }
}
